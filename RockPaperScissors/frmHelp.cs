using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Hide this form
            this.Hide();
        }

        // Runs when user clicks on Wikipedia link
        private void lnkWikipedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open abrowser at this address. Requires "using System.Diagnostics;" above
            Process.Start("https://en.wikipedia.org/wiki/Rock-paper-scissors");
        }

        // Hide form when close button clicked. See http://stackoverflow.com/questions/2021681/hide-form-instead-of-closing-when-close-button-clicked
        private void frmHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
