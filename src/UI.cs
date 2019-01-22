using System;
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
            _noRerollRadio.Checked = true;
            _dontRerollWounds.Checked = true;
            _woundingUseStandardRadio.Checked = true;

            _woundOnXBox.Hide();
            _woundMortalOnXBox.Hide();

            _flatShotsBox.Show();
            _atkShotsNumberBox.Hide();
            _atkShotsDBox.Hide();
            _atkDiceDType.Hide();
            _atkDamageDiceAmount.Hide();
            _flatDamageBox.Show();

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
            try
            {
                Chart chart = new Chart
                (
                Int32.Parse(_atkWsBsBox.Text),
                Int32.Parse(_flatShotsBox.Text),
                Int32.Parse(_atkStrBox.Text),
                Int32.Parse(m_atkAPBox.Text),
                Int32.Parse(_atkDamageDiceAmount.Text),
                Int32.Parse(_atkDiceDType.Text),
                Int32.Parse(_defToughness.Text),
                Int32.Parse(_defSave.Text),
                Int32.Parse(_invulSaveBox.Text),
                Int32.Parse(_atkShotsNumberBox.Text),
                Int32.Parse(_atkShotsDBox.Text),
                Int32.Parse(_flatDamageBox.Text),

                _noRerollRadio.Checked,
                _rerollOnesRadio.Checked,
                _rerollMisses.Checked,
                _rerollFailedWoundsRadio.Checked,
                _rerollWoundsOfOneRadio.Checked,
                _autoHitCheckbox.Checked,
                _woundOnXRadio.Checked,
                _woundMortalOnXRadio.Checked,
                _teslaCheckbox.Checked,
                _variableShotsCheckbox.Checked,
                _varableDamageCheckbox.Checked
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
            int yOffset = 40;

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
            _woundsPerModelBox.Text = wounds.ToString();
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
                _atkShotsNumberBox.Show();
                _atkShotsDBox.Show();
                _flatShotsBox.Hide();
            }
            else
            {
                _atkShotsNumberBox.Hide();
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
    }
}