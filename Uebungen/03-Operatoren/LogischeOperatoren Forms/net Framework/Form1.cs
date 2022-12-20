using System;
using System.Windows.Forms;

namespace ULogischeOperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            // Code ....
            // 1. Ausdruck: 4 > 3 && -4 > -3;
            LblAnzeige.Text = "Ergebnis: " + p;
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            // Code ....
            // 1. Ausdruck: 4 > 3 || -4 > -3;
            LblAnzeige.Text = "Ergebnis: " + p;
        }
    }
}
