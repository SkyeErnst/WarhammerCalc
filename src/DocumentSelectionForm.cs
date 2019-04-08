using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathHammer.src
{
    public partial class DocumentSelectionForm : Form
    {
        public DocumentSelectionForm()
        {
            InitializeComponent();
        }

        private void DocumentSelectionForm_Load(object sender, EventArgs e)
        {
            _yourArmyRadio.Checked = true;
            _otherPlayerArmyRadio.Checked = false;
        }

        private void YourArmyCheckChanged(object sender, EventArgs e)
        {
            if (true == _yourArmyRadio.Checked)
            {
                XmlHandler.SelectActiveArmy(ArmyListAllegiance.Attacking);
            }
        }

        private void OppArmyCheckChanged(object sender, EventArgs e)
        {
            if (true == _otherPlayerArmyRadio.Checked)
            {
                XmlHandler.SelectActiveArmy(ArmyListAllegiance.Defending);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
