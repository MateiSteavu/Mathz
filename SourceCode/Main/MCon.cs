using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Main
{
    public partial class MCon : Form
    {
        public MCon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(string.Equals(initcoef.Text, "Enter your problem here...")!=true && string.Equals(initp.Text, "Prefix:")!=true && string.Equals(finp.Text, "Prefix:") != true && string.Equals(im.Text, "Unit of measurment:") != true)
            {
                int ok = 0, pi = 0, pf = 0;
                float init, fin = 0;
                string initmeas, finmeas;

                bool vf(string meas)
                {
                    if (initmeas == meas && ok == 0)
                        return true;
                    if (finmeas == meas && ok == 1)
                        return true;
                    return false;
                }

                void get_meas(ref int m)
                {
                    if (vf("piko"))
                        m = -12;
                    if (vf("nano"))
                        m = -9;
                    if (vf("micro"))
                        m = -6;
                    if (vf("mili"))
                        m = -3;
                    if (vf("centi"))
                        m = -2;
                    if (vf("deci"))
                        m = -1;
                    if (vf("normal"))
                        m = 0;
                    if (vf("deca"))
                        m = 1;
                    if (vf("hecto"))
                        m = 2;
                    if (vf("kilo"))
                        m = 3;
                    if (vf("mega"))
                        m = 6;
                    if (vf("giga"))
                        m = 9;
                    if (vf("terra"))
                        m = 12;
                    ok = 1;
                }
                initmeas = initp.Text;
                int p;
                init = (float)Convert.ToDouble(initcoef.Text);
                finmeas = finp.Text;
                History.Text += "\n" + initp.Text + im.Text + "   "+ finp.Text + im.Text + "        ";
                get_meas(ref pi);
                get_meas(ref pf);
                p = pi - pf;
                fin = (float)(init * Pow(10, p));
                Results.Text = Convert.ToString(fin);
                History.Text += Results.Text;
            }
        }
    }
}
