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
    public partial class EC : Form
    {
        public EC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correct(ref string s)
            {
                string a = "";
                int i, nrpd = 0, nrpi = 0, nre = 0;
                while ("/*=)^".IndexOf(s[0]) != -1)
                    s = s.Remove(0, 1);
                for (i = 0; i < s.Length; i++)
                {
                    if (!char.IsDigit(s, i) && "()/*^+-=x".IndexOf(s[i]) == -1)
                    {
                        s = s.Remove(i, 1);
                        i = -1;
                    }
                    else
                        if (s[i] == '=')
                        nre++;
                    if (nre > 1)
                        s = s.Remove(i, s.Length - i);
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
                if (char.IsDigit(s[0]) || s[0] == 'x')
                {
                    a += "+";
                    a += s;
                    s = a;
                }
                if (nre == 0)
                    return 1;
                else
                    return 0;
            }

            void group(ref string y)
            {
                string a = "1", x = "", p = "*";
                int pro = 1, i = 0, j, k = 0, ok = 0;
                for (j = 0; j < y.Length; j++)
                    if (!char.IsDigit(y[j]))
                    {
                        if (y[j] == 'x')
                            if (p[0] == '*')
                            {
                                i++;
                                ok = 1;
                                if ((j - 1) > -1 && y[j - 1] != 'x')
                                    pro = pro * Convert.ToInt32(a);
                                k = 0;
                                a = "1";
                            }
                            else
                            {
                                i--;
                                ok = 1;
                                if ((j - 1) > -1 && y[j - 1] != 'x')
                                    pro = pro / Convert.ToInt32(a);
                                k = 0;
                                a = "1";
                            }
                        else
                            if (p[0] == '*' && k > 0)
                        {
                            pro = pro * Convert.ToInt32(a);
                            k = 0;
                            a = "1";
                        }
                        else
                                if (p[0] == '/' && k > 0)
                        {
                            pro = pro / Convert.ToInt32(a);
                            k = 0;
                            a = "1";
                        }
                        if (y[j] != 'x')
                            p = Convert.ToString(y[j]);
                    }
                    else
                    if (char.IsDigit(y[j]))
                    {
                        if (a == "1" && k == 0)
                            a = Convert.ToString(y[j]);
                        else
                            a += Convert.ToString(y[j]);
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
                if (i == 0)
                    y = a;
                else
                {
                    a += "x^";
                    x = Convert.ToString(i);
                    a += x;
                    y = a;
                }
            }

            void sum(ref string s)
            {
                string a = "", x = "", semn = "", e = "", coef = "", b = "";
                int sum = 0, i, j, k = 0, p = 0, ok = 0;
                int[] sums = new int[100], pow = new int[100];
                semn = Convert.ToString(s[0]);
                for (j = 1; j < s.Length; j++)
                {
                    if (char.IsDigit(s[j]) || "x^".IndexOf(s[j]) != -1)
                    {
                        a += Convert.ToString(s[j]);
                        k++;
                    }
                    else
                    {
                        ok = 0;
                        if (a.IndexOf("x^") != -1)
                            e = a.Remove(0, a.IndexOf("x^"));
                        coef = a;
                        if (string.IsNullOrEmpty(e) != true && e[0] == 'x')
                        {
                            coef = coef.Remove(coef.Length - e.Length, e.Length);
                            e = e.Remove(0, 2);
                            if (p > 0)
                            {
                                for (i = 0; i < p; i++)
                                    if (pow[i] == Convert.ToInt32(e) && semn[0] == '+')
                                    {
                                        sums[i] += Convert.ToInt32(coef);
                                        ok = 1;
                                    }
                                    else
                                        if (pow[i] == Convert.ToInt32(e) && semn[0] == '-')
                                    {
                                        sums[i] -= Convert.ToInt32(coef);
                                        ok = 1;
                                    }
                                if (ok == 0)
                                {
                                    pow[p] = Convert.ToInt32(e);
                                    if (semn[0] == '+')
                                        sums[p] += Convert.ToInt32(coef);
                                    else
                                        if (semn[0] == '-')
                                        sums[p] -= Convert.ToInt32(coef);
                                    p++;
                                }
                            }
                            else
                            {
                                pow[p] = Convert.ToInt32(e);
                                if (semn[0] == '+')
                                    sums[p] += Convert.ToInt32(coef);
                                else
                                    if (semn[0] == '-')
                                    sums[p] -= Convert.ToInt32(coef);
                                p++;
                            }
                        }
                        else
                            if (semn[0] == '+')
                            sum += Convert.ToInt32(coef);
                        else
                                if (semn[0] == '-')
                            sum -= Convert.ToInt32(coef);
                        semn = Convert.ToString(s[j]);
                        k = 0;
                        e = "";
                        coef = "";
                        a = "";
                    }
                }
                if (k > 0)
                {
                    ok = 0;
                    if (a.IndexOf("x^") != -1)
                        e = a.Remove(0, a.IndexOf("x^"));
                    coef = a;
                    if (string.IsNullOrEmpty(e) != true && e[0] == 'x')
                    {
                        coef = coef.Remove(coef.Length - e.Length, e.Length);
                        e = e.Remove(0, 2);
                        if (p > 0)
                        {
                            for (i = 0; i < p; i++)
                                if (pow[i] == Convert.ToInt32(e) && semn[0] == '+')
                                {
                                    sums[i] += Convert.ToInt32(coef);
                                    ok = 1;
                                }
                                else
                                    if (pow[i] == Convert.ToInt32(e) && semn[0] == '-')
                                {
                                    sums[i] -= Convert.ToInt32(coef);
                                    ok = 1;
                                }
                            if (ok == 1)
                            {
                                pow[p] = Convert.ToInt32(e);
                                if (semn[0] == '+')
                                    sums[p] += Convert.ToInt32(coef);
                                else
                                    if (semn[0] == '-')
                                    sums[p] -= Convert.ToInt32(coef);
                                p++;
                            }
                        }
                        else
                        {
                            pow[p] = Convert.ToInt32(e);
                            if (semn[0] == '+')
                                sums[p] += Convert.ToInt32(coef);
                            else
                                if (semn[0] == '-')
                                sums[p] -= Convert.ToInt32(coef);
                            p++;
                        }
                    }
                    else
                        if (semn[0] == '+')
                        sum += Convert.ToInt32(coef);
                    else
                            if (semn[0] == '-')
                        sum -= Convert.ToInt32(coef);
                    k = 0;
                }
                for (i = 0; i < p; i++)
                {
                    b = Convert.ToString(sums[i]);
                    if (char.IsDigit(b[0]) && b[0] != '0')
                    {
                        x += "+";
                        x += b;
                        x += "x^";
                        b = Convert.ToString(pow[i]);
                        x += b;
                        b = "";
                    }
                    else
                        if (b[0] != '0')
                    {
                        x += b;
                        x += "x^";
                        b = Convert.ToString(pow[i]);
                        x += b;
                        b = "";
                    }
                }
                if (sum != 0)
                {
                    if (sum > 0)
                        x += "+";
                    b = Convert.ToString(sum);
                    x += b;
                }
                if (string.IsNullOrEmpty(x) != true)
                    s = x;
                else
                    s = "0";
            }

            void ecg1(string s)
            {
                string a = "";
                int nri = 0, coef = 1, j, k = 0;

                for (j = 0; j < s.Length; j++)
                    if (char.IsDigit(s[j]))
                    {
                        a += Convert.ToString(s[j]);
                        k++;
                    }
                    else
                        if (s[j] != 'x')
                    {
                        a = "";
                        k = 0;
                        a += Convert.ToString(s[j]);
                        Console.WriteLine(a);
                        k++;
                    }
                    else
                            if (s[j] == 'x')
                        coef = Convert.ToInt32(a);
                nri = Convert.ToInt32(a);
                Results.Text = Convert.ToString((float)-(nri) / coef);
            }

            void radical(int delta, ref string a)
            {
                string aux = "";
                int p1 = 1, p2 = 1, d, po;
                for (d = 2; d <= Math.Sqrt(delta); d++)
                {
                    po = 0;
                    while (delta % d == 0)
                    {
                        po++;
                        delta = delta / d;
                    }
                    p1 *= (int)Math.Pow(d, po / 2);
                    p2 *= (int)Math.Pow(d, po % 2);
                }
                if (delta != 1)
                    p2 = p2 * delta;
                if (p1 != 1 && p2 != 1)
                {
                    a = Convert.ToString(p1);
                    a += "V";
                    a += Convert.ToString(p2);
                }
                else
                    if (p1 == 1 && p2 == 1)
                    a = "1";
                else
                        if (p1 == 1 && p2 != 1)
                {
                    a = "V";
                    a += Convert.ToString(p2);
                }
                else
                    a = Convert.ToString(p1);
            }

            void sol2(int a, int b, int delta)
            {
                string rad = null, p = "";
                int coef;
                radical(delta, ref rad);
                if (rad.IndexOf("V") != -1)
                {
                    p = rad.Remove(0, rad.IndexOf("V"));
                    rad = rad.Remove(rad.Length - p.Length, p.Length);
                    if (string.IsNullOrEmpty(rad) == true)
                        rad = "1";
                    if (b % (2 * a) == 0 && Convert.ToInt32(rad) % (2 * a) == 0)
                        Results.Text = $"x1={(float)-b / 2 / a}-{(float)Convert.ToInt32(rad) / 2 / a}{p} x2={ (float)-b / 2 / a}+{ (float)Convert.ToInt32(rad) / 2 / a}{p}";
                    else
                        Results.Text = $"x1=({-b}+{Convert.ToInt32(rad)}{p})/{2 * a} x2=({-b}-{Convert.ToInt32(rad)}{p})/{2 * a}";
                }
                else
                    Results.Text = $"x1={(float)(-b - Convert.ToInt32(rad)) / 2 / a} x2={(float)(-b + Convert.ToInt32(rad)) / 2 / a}";
            }

            void sol1(int a, int b, int delta)
            {
                Results.Text = Convert.ToString((float)-b / 2 / a);
            }

            void ecg2(string s)
            {
                string ec = "", sep = "+-", nr = "";
                int a = 0, b = 0, c = 0, delta, j = 0;
                ec = s;
                string[] tokens = ec.Split(new char[] { '+', '-' });
                foreach (string p in tokens)
                {
                    if (string.IsNullOrEmpty(p) != true)
                    {
                        nr = Convert.ToString(ec[j]);
                        nr += p;
                        if (nr.IndexOf("x^") != -1 && nr[nr.Length - 1] == '1')
                        {
                            nr = nr.Remove(nr.Length - 3);
                            b = Convert.ToInt32(nr);
                        }
                        else
                            if (nr.IndexOf("x^") != -1 && nr[nr.Length - 1] == '2')
                        {
                            nr = nr.Remove(nr.Length - 3);
                            a = Convert.ToInt32(nr);
                        }
                        else
                            c = Convert.ToInt32(nr);
                        j += p.Length + 1;
                        nr = "";
                    }
                }
                delta = (int)Math.Pow(b, 2) - 4 * c * a;
                if (delta > 0)
                    sol2(a, b, delta);
                else
                    if (delta == 0)
                    sol1(a, b, delta);
                else
                    Results.Text = "Nici-o solutie reala";
            }

            void solve()
            {
                string text = echolder.Text;
                string a = "", b = "", ecuation = "", c = "";
                int i = 0, j, max = 0, type;

                type = correct(ref text);
                ecuation = text;
                string[] tokens = text.Split(new char[] { '+', '-', ')', '(', '=' });
                foreach (string p in tokens)
                {
                    if (string.IsNullOrEmpty(p) != true)
                    {
                        a = p;
                        group(ref a);
                        c = Convert.ToString(text[i]);
                        if (c[0] == '=')
                            j = i;
                        b += c;
                        if ((i + 1) < text.Length && text[i + 1] == '-')
                        {
                            b += "-";
                            i++;
                        }
                        b += a;
                        i = i + p.Length + 1;
                    }
                }
                text = b;
                b = "";
                if (type != 0)
                {
                    text += "+";
                    sum(ref text);
                    History.Text += "\n";
                    Results.Text = text;
                }
                else
                {
                    for (j = 0; j < text.Length && text[j] != '='; j++)
                        a += Convert.ToString(text[j]);
                    for (j = j + 1; j < text.Length; j++)
                        b += Convert.ToString(text[j]);
                    if (char.IsDigit(b[0]))
                    {
                        ecuation = "+";
                        ecuation += b;
                        b = ecuation;
                    }
                    sum(ref b);
                    sum(ref a);
                    char[] d = b.ToCharArray();
                    for (i = 0; i < d.Length; i++)
                    {
                        if (d[i] == '+')
                            d[i] = '-';
                        else
                            if (d[i] == '-')
                            d[i] = '+';
                    }
                    b = new string(d);
                    if (b.Length == 1 && b[0] == '0') ;
                    else
                        a += b;
                    b = "";
                    sum(ref a);
                    text = a;
                    a += "=0    ";
                    History.Text += "\n";
                    History.Text += a;
                    string[] ts = text.Split(new char[] { '+', '-', ')', '(', '=' });
                    foreach (string p in ts)
                    {
                        if (p.IndexOf("x^") != -1)
                        {
                            b = p.Remove(0, p.IndexOf("x^") + 2);
                            if (Convert.ToInt32(b) > max)
                                max = Convert.ToInt32(b);
                        }
                        b = "";
                    }
                    type = max + 1;
                    switch (type)
                    {
                        case 1:
                            if (Convert.ToInt32(text) == 0)
                                Results.Text = "x element din R";
                            else
                                Results.Text = "x element din multime avida";
                            break;
                        case 2:
                            ecg1(text);
                            break;
                        case 3:
                            ecg2(text);
                            break;
                        default:
                            Results.Text = "Puteri prea mari";
                            break;
                    }
                }
            }

            solve();
            History.Text += Results.Text;
        }
    }
}
