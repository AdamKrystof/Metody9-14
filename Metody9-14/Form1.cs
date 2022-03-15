using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody9_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ObsahujeCislici(string a, out int soucetS, out int soucetL, out int soucetCif)
        {
            bool obsahuje = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= '0' && a[i] <= '9') obsahuje = true;
            }
            soucetCif = 0;
            soucetS = 0;
            soucetL = 0;
            if (obsahuje)
            {

                foreach (char znak in a)
                {
                    int cislo = Convert.ToInt32(znak);
                    if (Char.IsDigit(znak))
                        if (znak % 2 == 0) soucetS += cislo;
                        else soucetL += cislo;
                    soucetCif += cislo;
                }
            }
            else MessageBox.Show("Řetězec neobsahuje cifru.");
            return obsahuje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            int soucetCifer, soucetSud, soucetLich;
            if (ObsahujeCislici(vstup, out soucetSud, out soucetLich, out soucetCifer)) MessageBox.Show("Ano, řetězec obsahuje cifru, součet sudých je " + soucetSud + " a součet lichých je " + soucetLich + " a ciferný součet je " + soucetCifer);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
