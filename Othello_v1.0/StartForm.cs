using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello_v1._0
{
    public partial class StartForm : Form
    {
        private Form playForm;
        public static bool Debug;

        public StartForm()
        {
            InitializeComponent();
            Selecter.SelectedIndex = 0;
            label1.BackColor = Color.Transparent;
            Debug = isDebug.Checked;
        }

        private Rules SelectedRule()
        {
            Rules s;
            switch (Selecter.SelectedIndex) {
                case 1:
                    s = Rules.Revolution;
                    break;
                case 2:
                    s = Rules.AllRevolution;
                    break;
                default:
                    s = Rules.Normal;
                    break;
            }
            return s;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            playForm = new PlayForm(SelectedRule());
            playForm.ShowDialog();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(playForm != null) playForm.Dispose();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsDebug_CheckedChanged(object sender, EventArgs e)
        {
            Debug = isDebug.Checked;
        }
    }
}
