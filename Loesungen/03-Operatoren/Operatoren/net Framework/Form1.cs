using System;
using System.Windows.Forms;

namespace UOperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            int a = 5, b = 10;
            int z = 10, w = 100;
            double x = 1.0, y = 5.7;
            int n1 = 1, n2 = 17;

            LblAnzeige.Text = "Ergebnis:" +
                "\n1: " + (a > 0 && b != 10) +
                "\n2: " + (a > 0 || b != 10) +
                "\n3: " + (z != 0 || z > w || w - z == 90) +
                "\n4: " + (z == 11 && z > w || w - z == 90) +
                "\n5: " + (x >= .9 && y <= 5.8) +
                "\n6: " + (x >= .9 && !(y <= 5.8)) +
                "\n7: " + (n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17) +
                "\n8: " + (n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17);
        }
    }
}
