﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MathHammer.StatBlocks;

namespace MathHammer
{
    public partial class Ui : Form
    {

        private List<RollLine> _linesAdded;
        private List<Label> _woundLabels;

        public Ui()
        {
            InitializeComponent();

            _linesAdded = new List<RollLine>();
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
                Chart chart = new Chart
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

                MainProgram.Calc.Roll(ref chart);

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
        private void DisplayResults(Chart crt)
        {

            if (_linesAdded.Count > 0)
            {
                foreach (RollLine line in _linesAdded)
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

            _totalHitsNum.Text = crt.FinalHitList.Count.ToString();
            _woundsTotalNum.Text = crt.SuccessfulWounds.Count.ToString();
            _failedSavesNum.Text = crt.FailedSaves.Count.ToString();
            _damageTotalNum.Text = Sum(crt.Damage).ToString();

            Point currPoint;
            int yOffset = 50;

            currPoint = _resultsLabel.Location;
            currPoint.Y += yOffset;

            for (int i = 0; i < crt.RollStats.Count; i++)
            {
                this.Controls.Add(crt.RollStats[i]);
                _linesAdded.Add(crt.RollStats[i]);
                crt.RollStats[i].Location = currPoint;
                currPoint.Y += yOffset;
            }

            Point tmpPoint = _damageResultsLabel.Location;

            for (int i = 0; i < crt.Damage.Count; i++)
            {
                Label lbl = new Label();
                _woundLabels.Add(lbl);

                lbl.AutoSize = true;

                lbl.Text = "Wound: " + (i + 1) + "," + " Damage: " + crt.Damage[i];

                this.Controls.Add(lbl);

                tmpPoint.Y += 30;

                lbl.Location = tmpPoint;
            }
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

        private static int Sum(IReadOnlyList<int> values)
        {
            int total = 0;

            for (int i = 0; i < values.Count; i++)
            {
                total += values[i];
            }

            return total;
        }

        private enum EqSelection
        {
            Geq = 0,
            Meq = 1,
            Teq = 2,
            Veq = 3,
            Keq = 4
        }

        private void _geqButton_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Geq);
        }

        private void _meqButton_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Meq);
        }

        private void _teqButton_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Teq);
        }

        private void _veqButton_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Veq);
        }

        private void _keqButton_Click(object sender, EventArgs e)
        {
            FillEquivalentValues(EqSelection.Keq);
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
            _geqButton_Click(sender, e);
        }

        private void mEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _meqButton_Click(sender, e);
        }

        private void tEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _teqButton_Click(sender, e);
        }

        private void vEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _veqButton_Click(sender, e);
        }

        private void kEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _keqButton_Click(sender, e);
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
    }
}