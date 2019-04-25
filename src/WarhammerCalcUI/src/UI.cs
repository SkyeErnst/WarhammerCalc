using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WarhammerCalcData;
using WarhammerCalcData.UnitEquivalencyStats;

namespace WarhammerCalcUI
{
    public partial class Ui : Form
    {

        private List<RollLineDisplay> _linesAdded;
        private List<Label> _woundLabels;

        private Color _defaultColor = Color.Black;
        private Color _successColor = Color.ForestGreen;
        private Color _failColor = Color.Red;
        private Color _specialColor = Color.Aquamarine;
        private Color _whiteoutColor = Color.White;

        private const string NaText = "N/A";
        private const string TeslaText = "TESLA";
        private const string AutohitText = "AUTO";
        private const string MortalWoundText = "MORTAL";

        public Ui()
        {
            InitializeComponent();

            _linesAdded = new List<RollLineDisplay>();
            _woundLabels = new List<Label>();
        }

        /// <summary>
        /// Windows Forms generated method. Generates a new Chart object with the values in the form,
        /// and passes it by reference to the Roll method. Passed by reference because of the number
        /// of lists that are inside the Chart object, and also because the data on the chart object needs to be
        /// changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e)
        {

            if ("" == _flatShotsBox.Text)
            {
                _flatShotsBox.Text = "0";
            }
            if ("" == _atkVariableShotsNumberBox.Text)
            {
                _atkVariableShotsNumberBox.Text = "0";
            }
            if ("" == _atkShotsDBox.Text)
            {
                _atkShotsDBox.Text = "0";
            }

            if ("" == _flatDamageBox.Text)
            {
                _flatDamageBox.Text = "0";
            }
            if ("" == _atkDamageDiceAmount.Text)
            {
                _atkDamageDiceAmount.Text = "0";
            }
            if ("" == _atkDiceDType.Text)
            {
                _atkDiceDType.Text = "0";
            }
            if ("" == _xResolveApWoundValue.Text || "" == _xResolveApApValue.Text)
            {
                _xResolveApWoundValue.Text = "0";
                _xResolveApApValue.Text = "0";
            }

            if ("" == _xResolveDamageHitValue.Text || "" == _xResolveDamageDamageValue.Text)
            {
                _xResolveDamageHitValue.Text = "0";
                _xResolveDamageDamageValue.Text = "0";
            }

            try
            {
                ShotChart chart = new ShotChart
                (
                Int32.Parse(_atkWsBsBox.Text),
                Int32.Parse(_flatShotsBox.Text),
                Int32.Parse(_atkStrBox.Text),
                Int32.Parse(_atkAPBox.Text),
                Int32.Parse(_atkDamageDiceAmount.Text),
                Int32.Parse(_atkDiceDType.Text),
                Int32.Parse(_defToughness.Text),
                Int32.Parse(_defSave.Text),
                Int32.Parse(_invulSaveBox.Text),
                Int32.Parse(_atkVariableShotsNumberBox.Text),
                Int32.Parse(_atkShotsDBox.Text),
                Int32.Parse(_flatDamageBox.Text),
                Int32.Parse(_woundOnXBox.Text),
                Int32.Parse(_woundMortalOnXBox.Text),
                Int32.Parse(_xResolveApWoundValue.Text),
                Int32.Parse(_xResolveApApValue.Text),
                Int32.Parse(_xResolveDamageHitValue.Text),
                Int32.Parse(_xResolveDamageDamageValue.Text),


                _noRerollHitRadio.Checked,
                _rerollOnesRadio.Checked,
                _rerollMissesRadio.Checked,
                _rerollFailedWoundsRadio.Checked,
                _rerollWoundsOfOneRadio.Checked,
                _autoHitCheckbox.Checked,
                _woundOnXRadio.Checked,
                _woundMortalOnXRadio.Checked,
                _teslaCheckbox.Checked,
                _variableShotsCheckbox.Checked,
                _varableDamageCheckbox.Checked,
                _xResolveNormallyRadio.Checked,
                _xResolveApRadio.Checked,
                _xResolveDamageRadio.Checked
                );

                MainProgram.DiceRollRef.Roll(ref chart);

                DisplayResults(chart);
            }
            catch (Exception exception)
            {
                string errorMessage =
                    "Something went wrong. Ensure that all visible text boxes are filled in.\n\n" 
                    + exception.Message + "\n\n"
                    + "Stacktrace:\n"
                    + exception.ToString();
                MessageBox.Show(errorMessage, "ERROR");
            }
        }

        /// <summary>
        /// Given a Chart object, 
        /// </summary>
        /// <param name="crt"></param>
        private void DisplayResults(ShotChart crt)
        {
            #region Removes old data
            if (_linesAdded.Count > 0)
            {
                foreach (RollLineDisplay line in _linesAdded)
                {
                    this.Controls.Remove(line);
                }
                _linesAdded.Clear();
            }
            if (_woundLabels.Count > 0)
            {
                foreach (Label lbl in _woundLabels)
                {
                    this.Controls.Remove(lbl);
                }
                _woundLabels.Clear();
            }
            #endregion

            ConvertRollLineSimple(ref crt, out _linesAdded);

            #region Generate Labels
            int count = _linesAdded.Count;
            Point currPoint;
            int yOffset = 50;

            currPoint = _resultsLabel.Location;
            currPoint.Y += yOffset;

            for (int i = 0; i < count; i++)
            {
                _linesAdded[i].Location = currPoint;
                currPoint.Y += yOffset;
            }

            #endregion


            #region Displays damage by wound
            int cnt = crt.RollStats.Count;
            Point tmpPoint = _damageResultsLabel.Location;

            for (int i = 0; i < cnt; i++)
            {
                if (RollOutcome.Fail == crt.RollStats[i].ArmorRollOutcome)
                {
                    
                    Label lbl = new Label();
                    _woundLabels.Add(lbl);

                    lbl.AutoSize = true;

                    lbl.Text = "Wound: " + (i + 1) + "," + " Damage: " + crt.RollStats[i].DamageRoll;

                    this.Controls.Add(lbl);

                    tmpPoint.Y += 30;

                    lbl.Location = tmpPoint;
                }
            }

            #endregion

            this.Controls.AddRange(_linesAdded.ToArray());

            _damageTotalNum.Text = Sum(crt.RollStats).ToString();
            _totalHitsNum.Text = Count(crt.RollStats, ValueGrab.TotalHits).ToString();
            _woundsTotalNum.Text = Count(crt.RollStats, ValueGrab.TotalWounds).ToString();
            _failedSavesNum.Text = Count(crt.RollStats, ValueGrab.FailedSaves).ToString();
        }

        private void FillEquivalentValues(EqSelection selection)
        {
            switch (selection)
            {
                case EqSelection.Geq:
                    GeqStats gst = new GeqStats();
                    FillHelper(gst.Tough, gst.Save, gst.InvulSave, gst.Wounds);
                    break;
                case EqSelection.Meq:
                    MeqStats mst = new MeqStats();
                    FillHelper(mst.Tough, mst.Save, mst.InvulSave, mst.Wounds);
                    break;
                case EqSelection.Teq:
                    TeqStats tst = new TeqStats();
                    FillHelper(tst.Tough, tst.Save, tst.InvulSave, tst.Wounds);
                    break;
                case EqSelection.Veq:
                    VeqStats vst = new VeqStats();
                    FillHelper(vst.Tough, vst.Save, vst.InvulSave, vst.Wounds);
                    break;
                case EqSelection.Keq:
                    KeqStats kst = new KeqStats();
                    FillHelper(kst.Tough, kst.Save, kst.InvulSave, kst.Wounds);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(selection), selection, null);
            }
        }

        /// <summary>
        /// Helper method for the FillEquivalentValues method.
        /// Reduces the amount of copy/paste that would otherwise need to be done.
        /// </summary>
        /// <param name="tough"></param>
        /// <param name="save"></param>
        /// <param name="invulSave"></param>
        /// <param name="wounds"></param>
        private void FillHelper(int tough, int save, int invulSave, int wounds)
        {
            _defToughness.Text = tough.ToString();
            _defSave.Text = save.ToString();
            _invulSaveBox.Text = invulSave.ToString();
        }

        /// <summary>
        /// Simple summing method. Give it a readonly list,
        /// and it will give you the sum of the items.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static int Sum(List<RollLine> values)
        {
            int total = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].DamageRoll > 0)
                {
                    total += values[i].DamageRoll;
                }
            }

            return total;
        }

        /// <summary>
        /// Returns count of the number of instances of successful
        /// rolls of the given type
        /// </summary>
        /// <param name="values"></param>
        /// <param name="valGrab"></param>
        private int Count(List<RollLine> values, ValueGrab valGrab)
        {
            int count = values.Count;
            int instanceCount = 0;

            for (int i = 0; i < count; i++)
            {
                switch (valGrab)
                {
                    case ValueGrab.Hit:
                        if (RollOutcome.Success == values[i].HitOutcome)
                        {
                            instanceCount++;
                        }
                        break;
                    case ValueGrab.HitReRoll:
                        if (RollOutcome.Success == values[i].HitRerollOutcome)
                        {
                            instanceCount++;
                        }
                        break;
                    case ValueGrab.TotalHits:
                        if (RollOutcome.Success == values[i].HitOutcome
                            ||
                            RollOutcome.Success == values[i].HitRerollOutcome)
                        {
                            instanceCount++;
                        }
                        break;
                    case ValueGrab.Wound:
                        if (RollOutcome.Success == values[i].WoundOutcome)
                        {
                            instanceCount++;
                        }
                        break;
                    case ValueGrab.WoundReRoll:
                        if (RollOutcome.Success == values[i].WoundRerollOutcome)
                        {
                            instanceCount++;
                        }
                        break;
                    case ValueGrab.TotalWounds:
                        if (RollOutcome.Success == values[i].WoundOutcome
                            ||
                            RollOutcome.Success == values[i].WoundRerollOutcome)
                        {
                            instanceCount++;
                        }
                        break;
                    case ValueGrab.FailedSaves:
                        if (RollOutcome.Fail == values[i].ArmorRollOutcome)
                        {
                            instanceCount++;
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(valGrab), valGrab, null);
                }
            }

            return instanceCount;
        }

        private enum EqSelection
        {
            Geq = 0,
            Meq = 1,
            Teq = 2,
            Veq = 3,
            Keq = 4
        }

        private void WoundRollXRadioChanged(object sender, EventArgs e)
        {
            if (true == _woundOnXRadio.Checked)
            {
                _woundOnXBox.Show();
            }
            else
            {
                _woundOnXBox.Hide();
            }
        }

        private void MortalWoundOnXRadioChanged(object sender, EventArgs e)
        {
            if (true == _woundMortalOnXRadio.Checked)
            {
                _woundMortalOnXBox.Show();
            }
            else
            {
                _woundMortalOnXBox.Hide();
            }
        }

        private void VariableShotsCheckChanged(object sender, EventArgs e)
        {
            if (true == _variableShotsCheckbox.Checked)
            {
                _atkVariableShotsNumberBox.Show();
                _atkShotsDBox.Show();

                _flatShotsBox.Hide();
            }
            else
            {
                _atkVariableShotsNumberBox.Hide();
                _atkShotsDBox.Hide();

                _flatShotsBox.Show();
            }
        }

        private void VariableDamageCheckedChanged(object sender, EventArgs e)
        {
            if (true == _varableDamageCheckbox.Checked)
            {
                _flatDamageBox.Hide();
                _atkDamageDiceAmount.Show();
                _atkDiceDType.Show();
            }
            else
            {
                _flatDamageBox.Show();
                _atkDamageDiceAmount.Hide();
                _atkDiceDType.Hide();
            }
        }

        private void Ui_Load(object sender, EventArgs e)
        {
            _noRerollHitRadio.Checked = true;
            _dontRerollWounds.Checked = true;
            _woundingUseStandardRadio.Checked = true;

            _woundOnXBox.Hide();
            _woundMortalOnXBox.Hide();

            _xResolveNormallyRadio.Checked = true;
            _xResolveApWoundValue.Hide();
            _xResolveApApValue.Hide();
            _xResolveDamageHitValue.Hide();
            _xResolveDamageDamageValue.Hide();

            _flatShotsBox.Show();
            _atkVariableShotsNumberBox.Hide();
            _atkShotsDBox.Hide();
            _atkDiceDType.Hide();
            _atkDamageDiceAmount.Hide();
            _flatDamageBox.Show();

            _noRerollHitRadio.TabStop = false;
            _rerollOnesRadio.TabStop = false;
            _rerollMissesRadio.TabStop = false;
            _autoHitCheckbox.TabStop = false;
            _dontRerollWounds.TabStop = false;
            _rerollWoundsOfOneRadio.TabStop = false;
            _rerollFailedWoundsRadio.TabStop = false;
            _woundingUseStandardRadio.TabStop = false;
            _woundOnXRadio.TabStop = false;
            _woundMortalOnXRadio.TabStop = false;

            _variableShotsCheckbox.TabStop = false;
            _varableDamageCheckbox.TabStop = false;
            _teslaCheckbox.TabStop = false;
        }

        private void LeftAdjustCursor(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(MaskedTextBox))
            {
                MaskedTextBox snd = (MaskedTextBox)sender;

                snd.Text = "";
                snd.Select(0,0);
            }
        }

        private void gEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Geq);
        }

        private void mEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Meq);
        }

        private void tEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Teq);
        }

        private void vEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Veq);
        }

        private void kEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Keq);
        }

        private void _xResolveApRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Checked will equal true when that radio is selected, so we can set
            // the visibility directly without the need of if statements.

            _xResolveApWoundValue.Visible = _xResolveApRadio.Checked;
            _xResolveApApValue.Visible = _xResolveApRadio.Checked;
        }

        private void _xResolveDamageRadio_CheckedChanged(object sender, EventArgs e)
        {
            _xResolveDamageHitValue.Visible = _xResolveDamageRadio.Checked;
            _xResolveDamageDamageValue.Visible = _xResolveDamageRadio.Checked;
        }

        /// <summary>
        /// Takes a RollLine and converts it for full display for use in non-analyzing mode.
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="convertedList"></param>
        private void ConvertRollLineSimple(ref ShotChart chart, out List<RollLineDisplay> convertedList)
        {
            int count = chart.RollStats.Count;
            convertedList = new List<RollLineDisplay>();

            for (int i = 0; i < count; i++)
            {
                convertedList.Add(new RollLineDisplay());
                RollLineDisplay currDisplay = convertedList[i];
                RollLine currChartLine = chart.RollStats[i];

                try
                {
                    currDisplay.HitValue.Text = currChartLine.HitRoll.ToString();
                    currDisplay.HitRerollValue.Text = currChartLine.HitReroll.ToString();

                    currDisplay.WoundValue.Text = currChartLine.Wound.ToString();
                    currDisplay.WoundRerollValue.Text = currChartLine.WoundReroll.ToString();

                    currDisplay.ArmorRollValue.Text = currChartLine.ArmorRoll.ToString();
                    currDisplay.ArmorReRollValue.Text = currChartLine.ArmorReRoll.ToString();

                    currDisplay.DamageValue.Text = currChartLine.DamageRoll.ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message + "\n\n" + "Trace log: " + e.ToString());
                }

                #region Text assignment
                if
                (
                    State.Tesla == currChartLine.HitState
                    ||
                    State.Tesla == currChartLine.HitRerollState
                )
                {
                    currDisplay.HitValue.Text = TeslaText;
                    currDisplay.HitRerollValue.Text = TeslaText;
                }

                if (State.Autohit == currChartLine.HitState)
                {
                    currDisplay.HitValue.Text = AutohitText;
                    currDisplay.HitRerollValue.Text = AutohitText;
                }

                if (State.MortalWound == currChartLine.HitState)
                {
                    currDisplay.HitValue.Text = MortalWoundText;
                    currDisplay.HitRerollValue.Text = MortalWoundText;
                    currDisplay.WoundValue.Text = MortalWoundText;
                    currDisplay.WoundRerollValue.Text = MortalWoundText;
                }

                #endregion

                #region Color assignment

                // If we should continue to the next set of results
                bool cont = false;

                #region Hit

                // If the outcome of the hit roll is ANYTHING but success
                if (RollOutcome.Success != currChartLine.HitOutcome)
                {
                    // if either hit or reroll hit failed
                    if (RollOutcome.Fail == currChartLine.HitOutcome ||
                        RollOutcome.Fail == currChartLine.HitRerollOutcome)
                    {
                        currDisplay.HitValue.ForeColor = _failColor;
                    }

                    if (RollOutcome.Success == currChartLine.HitRerollOutcome)
                    {
                        currDisplay.HitRerollValue.ForeColor = _successColor;
                        cont = true;
                    }
                    else if(RollOutcome.Fail == currChartLine.HitRerollOutcome)
                    {
                        currDisplay.HitRerollValue.ForeColor = _failColor;
                        cont = false;
                    }

                    else if (State.Tesla == currChartLine.HitState)
                    {
                        currDisplay.HitValue.ForeColor = _specialColor;
                        currDisplay.HitRerollValue.ForeColor = _specialColor;
                        cont = true;
                    }
                }
                else
                {
                    currDisplay.HitValue.ForeColor = _successColor;
                    cont = true;
                }
                #endregion

                #region Wound

                if (true == cont)
                {
                    if (RollOutcome.Success != currChartLine.WoundOutcome)
                    {
                        if (RollOutcome.Fail == currChartLine.WoundOutcome ||
                            RollOutcome.Fail == currChartLine.WoundRerollOutcome)
                        {
                            currDisplay.WoundValue.ForeColor = _failColor;
                        }

                        if (RollOutcome.Success == currChartLine.WoundRerollOutcome)
                        {
                            currDisplay.WoundRerollValue.ForeColor = _successColor;
                            cont = true;
                        }
                        else if (RollOutcome.Fail == currChartLine.WoundRerollOutcome)
                        {
                            currDisplay.WoundRerollValue.ForeColor = _failColor;
                            cont = false;
                        }
                    }
                    else
                    {
                        currDisplay.WoundValue.ForeColor = _successColor;
                        cont = true;
                    }
                }
                #endregion

                #region Armor
                if (true == cont)
                {
                    if (RollOutcome.Success != currChartLine.ArmorRollOutcome)
                    {
                        if (RollOutcome.Fail == currChartLine.ArmorRollOutcome ||
                            RollOutcome.Fail == currChartLine.ArmorReRollOutcome)
                        {
                            currDisplay.ArmorRollValue.ForeColor = _failColor;
                        }

                        if (RollOutcome.Success == currChartLine.ArmorReRollOutcome)
                        {
                            currDisplay.ArmorReRollValue.ForeColor = _successColor;
                            cont = true;
                        }
                        else if (RollOutcome.Fail == currChartLine.ArmorReRollOutcome)
                        {
                            currDisplay.ArmorReRollValue.ForeColor = _failColor;
                            cont = false;
                        }
                    }
                    else
                    {
                        currDisplay.ArmorRollValue.ForeColor = _successColor;
                        cont = true;
                    }
                }
                #endregion

                #region Whiteout
                if (State.Tesla != currChartLine.HitState)
                {
                    if (0 == currChartLine.HitReroll)
                    {
                        currDisplay.HitRerollValue.ForeColor = _whiteoutColor;
                    }
                }

                if (0 == currChartLine.Wound)
                {
                    currDisplay.WoundValue.ForeColor = _whiteoutColor;
                }
                if (0 == currChartLine.WoundReroll)
                {
                    currDisplay.WoundRerollValue.ForeColor = _whiteoutColor;
                }

                if (0 == currChartLine.ArmorRoll)
                {
                    currDisplay.ArmorRollValue.ForeColor = _whiteoutColor;
                }
                if (0 == currChartLine.ArmorReRoll)
                {
                    currDisplay.ArmorReRollValue.ForeColor = _whiteoutColor;
                }

                if (0 == currChartLine.DamageRoll)
                {
                    currDisplay.DamageValue.ForeColor = _whiteoutColor;
                }
                #endregion

                #endregion
            }
        }

        private enum ValueGrab
        {
            Hit = 0,
            HitReRoll,
            TotalHits,
            Wound,
            WoundReRoll,
            TotalWounds,
            FailedSaves
        }
    }
}