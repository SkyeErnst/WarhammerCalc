using System.Windows.Forms;

namespace MathHammer
{
    public partial class RollLine : UserControl
    {
        public RollLine()
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
