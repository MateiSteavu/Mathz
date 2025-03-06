using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool correct(ref string s)
            {
                string a = "";
                int i, nrpd = 0, nrpi = 0;
                while ("/*=".IndexOf(s[0]) != -1)
                    s = s.Remove(0, 1);

                for (i = 0; i < s.Length; i++)
                {
                    if (!char.IsDigit(s, i) && "()/*^+-=".IndexOf(s[i]) == -1)
                    {
                        s = s.Remove(i, 1);
                        i = -1;
                    }
                }

                for (i = 0; i < s.Length; i++)
                    if (s[i] == '(')
                        nrpd++;
                    else
                        if (s[i] == ')')
                        if (nrpd > nrpi)
                            nrpi++;
                        else
                        {
                            s = s.Remove(i, 1);
                            i--;
                        }

                if (char.IsDigit(s[0]))
                {
                    a += "+";
                    a += s;
                    s = a;
                }

                if (nrpd == nrpi)
                    return true;
                else
                    return false;
            }

            void group(ref string y)
            {
                string a = "", p = "*";
                int pro = 1, j, k = 0, ok = 0;
                for (j = 0; j < y.Length; j++)
                    if (!char.IsDigit(y[j]))
                    {
                        if (p[0] == '*' && k > 0)
                        {
                            pro = pro * Convert.ToInt32(a);
                            k = 0;
                            a = "";
                        }
                        else
                            if (p[0] == '/' && k > 0)
                        {
                            pro = pro / Convert.ToInt32(a);
                            k = 0;
                            a = "";
                        }
                        if (y[j] != 'x')
                            p = Convert.ToString(y[j]);
                    }
                    else
                        if (char.IsDigit(y[j]))
                    {
                        a = a + Convert.ToString(y[j]);
                        k++;
                    }
                if (ok == 0 && p[0] == '*')
                    pro = pro * Convert.ToInt32(a);
                else
                    if (k > 0)
                {
                    if (p[0] == '*')
                        pro = pro * Convert.ToInt32(a);
                    else
                        pro = pro / Convert.ToInt32(a);
                    a = "";
                }
                a = Convert.ToString(pro);
                y = a;
            }

            void sum(ref string y)
            {
                string a = "", x = "", p = "+";
                int sum = 0, i = 0, j, k = 0, ok = 0;
                for (j = 0; j < y.Length; j++)
                    if (!char.IsDigit(y[j]) && "/*".IndexOf(y[j]) == -1)
                    {
                        if (p[0] == '+' && k > 0)
                        {
                            group(ref a);
                            sum = sum + Convert.ToInt32(a);
                            k = 0;
                            a = "";
                        }
                        else
                            if (p[0] == '-' && k > 0)
                        {
                            group(ref a);
                            sum = sum - Convert.ToInt32(a);
                            a = "";
                            k = 0;
                        }
                        p = Convert.ToString(y[j]);
                    }
                    else
                        if (char.IsDigit(y[j]) || "/*".IndexOf(y[j]) != -1)
                    {
                        a = a + Convert.ToString(y[j]);
                        k++;
                    }
                if (ok == 0 && p[0] == '+')
                {
                    group(ref a);
                    sum = sum + Convert.ToInt32(a);
                }
                else
                    if (k > 0)
                {
                    if (p[0] == '+')
                    {
                        group(ref a);
                        sum = sum + Convert.ToInt32(a);
                    }
                    else
                    {
                        group(ref a);
                        sum = sum - Convert.ToInt32(a);
                    }
                    a = "";
                }
                a = Convert.ToString(sum);
                y = a;
            }

            string ec = ExHolder.Text;
            History.Text += "\n";
            History.Text += ec;
            History.Text += "    ";
            if (correct(ref ec) == true)
            {
                sum(ref ec);
                Results.Text = ec;
            }
            else
                Results.Text = "Verificati scrierea!";

            History.Text += Results.Text;
        }
    }
}
