using System.Windows.Forms;

namespace WarhammerCalcData
{
    public partial class RollLineDisplay : UserControl
    {
        public RollLineDisplay()
        {
            InitializeComponent();
        }

        private void RollLine_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].TabStop = false;
            }
        }
    }
}
