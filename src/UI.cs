using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MathHammer.src;

namespace MathHammer
{
    public partial class MathHammer : Form
    {
        private List<Label> _labels;

        public MathHammer()
        {
            InitializeComponent();
        }

        private void m_rollButton_Click(object sender, EventArgs e)
        {
            Chart crt = new Chart
            {
                WsBs = Int32.Parse((_atkWsBsBox.Text)),
                Shots = Int32.Parse(_atkShotsBox.Text),
                Strength = Int32.Parse(_atkStrBox.Text),
                Ap = Int32.Parse(m_atkAPBox.Text),
                DiceNum = Int32.Parse(_atkDiceAmount.Text),
                DiceType = Int32.Parse(_atkDiceD.Text),
                Tough = Int32.Parse(_defToughness.Text),
                Save = Int32.Parse(_defSave.Text),
                InvulSave = Int32.Parse(_invulSaveBox.Text)
            };


            MainProgram.Calc.Roll(ref crt);

            DisplayResults(crt);
        }

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
                lbl.Text = i.ToString();
                lbl.ForeColor = clr;

                this.Controls.Add(lbl);

                lbl.Location = currPoint;
                _labels.Add((lbl));

                currPoint.Y += yOffset;
            }
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
    }
}
