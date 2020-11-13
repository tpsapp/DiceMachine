using System;
using System.Windows.Forms;

namespace DiceMachine
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();

            Random rResult = new Random();

            int iResult = 0;
            int iTotal = 0;

            for (int i = 0; i < nudDice.Value; i++)
            {
                iResult = rResult.Next(1, (int)nudSides.Value + 1);
                lbResults.Items.Add("Roll " + (i + 1).ToString() + ": " + iResult.ToString());
                iTotal += iResult;
            }

            lbResults.Items.Add("Total: " + iTotal.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
        }
    }
}
