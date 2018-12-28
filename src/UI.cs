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
            Chart crt;

            crt = MainProgram.Calc.Roll(Int32.Parse((_atkWsBsBox.Text)),
                Int32.Parse(_atkShotsBox.Text),
                Int32.Parse(_atkStrBox.Text),
                Int32.Parse(m_atkAPBox.Text),
                Int32.Parse(_atkDiceAmount.Text),
                Int32.Parse(_atkDiceD.Text),
                Int32.Parse(_defToughness.Text),
                Int32.Parse(_defSave.Text));

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
                if (_labels.Count != 0)
                {
                    CascadeValues(_labels[_labels.Count - 1].Location, crt.ShotsHit, successColor);
                }
                else
                {
                    CascadeValues(_hitResults.Location, crt.ShotsHit, failColor);
                }
            }

            if (crt.FailedWounds.Count > 0)
            {
                CascadeValues(_woundResults.Location, crt.FailedWounds, failColor);
            }

            if (crt.SuccessfulWounds.Count > 0)
            {
                CascadeValues(_labels[_labels.Count - 1].Location, crt.SuccessfulWounds, successColor);
            }

            if (crt.FailedSaves.Count > 0)
            {
                CascadeValues(_saveResultsLabel.Location, crt.FailedSaves, failColor);
            }

            if (crt.SuccessfulSaves.Count > 0)
            {
                CascadeValues(_labels[_labels.Count - 1].Location, crt.SuccessfulSaves, successColor);
            }

            CascadeValues(_damageResultsLabel.Location, crt.Damage, defaultColor);
        }

        private void CascadeValues(Point startPoint, List<int> values, Color clr)
        {
            int yOffset = 27;
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

        private int Sum(List<int> values)
        {
            int total = 0;

            for (int i = 0; i < values.Count; i++)
            {
                total += values[i];
            }

            return total;
        }

        private enum CascadeType
        {
            Hit = 0,
            Wound = 1,
            Save = 2,
            Damage = 3
        }
    }
}
