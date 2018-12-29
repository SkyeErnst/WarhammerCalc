using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MathHammer.src;
using MathHammer.src.StatBlocks;

namespace MathHammer
{
    public partial class MathHammer : Form
    {
        /// <summary>
        /// List of all the labels that we have added to the form.
        /// </summary>
        private List<Label> _labels;

        public MathHammer()
        {
            InitializeComponent();
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
            Chart crt = new Chart
                (
                Int32.Parse(_atkWsBsBox.Text),
                Int32.Parse(_atkShotsBox.Text),
                Int32.Parse(_atkStrBox.Text),
                Int32.Parse(m_atkAPBox.Text),
                Int32.Parse(_atkDiceAmount.Text),
                Int32.Parse(_atkDiceD.Text),
                Int32.Parse(_defToughness.Text),
                Int32.Parse(_defSave.Text),
                Int32.Parse(_invulSaveBox.Text)
                );

            MainProgram.Calc.Roll(ref crt);

            DisplayResults(crt);
        }

        /// <summary>
        /// Given a Chart object, 
        /// </summary>
        /// <param name="crt"></param>
        private void DisplayResults(Chart crt)
        {
            if (null != _labels)
            {
                foreach (Label label in _labels)
                {
                    Controls.Remove((label));
                }

                _labels.Clear();
            }

            Color failColor = Color.Red;
            Color successColor = Color.Green;
            Color defaultColor = Color.Black;

            _labels = new List<Label>();

            _totalHitsNum.Text = crt.ShotsHit.Count.ToString();
            _woundsTotalNum.Text = crt.SuccessfulWounds.Count.ToString();
            _failedSavesNum.Text = crt.FailedSaves.Count.ToString();
            _damageTotalNum.Text = Sum(crt.Damage).ToString();

            if (crt.ShotsMissed.Count > 0)
            {
                CascadeValues(_hitResults.Location, crt.ShotsMissed, failColor);
            }

            if (crt.ShotsHit.Count > 0)
            {
                if (crt.ShotsMissed.Count > 0)
                {
                    CascadeValues(_labels[_labels.Count - 1].Location, crt.ShotsHit, successColor);
                }
                else
                {
                    CascadeValues(_hitResults.Location, crt.ShotsHit, successColor);
                }
            }

            if (crt.FailedWounds.Count > 0)
            {
                CascadeValues(_woundResults.Location, crt.FailedWounds, failColor);
            }

            if (crt.SuccessfulWounds.Count > 0)
            {
                if (crt.FailedWounds.Count > 0)
                {
                    CascadeValues(_labels[_labels.Count - 1].Location, crt.SuccessfulWounds, successColor);
                }
                else
                {
                    CascadeValues(_woundResults.Location, crt.SuccessfulWounds, successColor);
                }
            }

            if (crt.FailedSaves.Count > 0)
            {
                CascadeValues(_saveResultsLabel.Location, crt.FailedSaves, failColor);
            }

            if (crt.SuccessfulSaves.Count > 0)
            {
                if (crt.FailedSaves.Count > 0)
                {
                    CascadeValues(_labels[_labels.Count - 1].Location, crt.SuccessfulSaves, successColor);
                }
                else
                {
                    CascadeValues(_saveResultsLabel.Location, crt.SuccessfulSaves, successColor);
                }
            }

            CascadeValues(_damageResultsLabel.Location, crt.Damage, defaultColor);
        }

        private void CascadeValues(Point startPoint, List<int> values, Color clr)
        {
            int yOffset = 28;
            Point currPoint = startPoint;
            currPoint.Y += yOffset;


            for (int i = 0; i < values.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = values[i].ToString();
                lbl.ForeColor = clr;

                this.Controls.Add(lbl);

                lbl.Location = currPoint;
                _labels.Add((lbl));

                currPoint.Y += yOffset;
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
    }
}
