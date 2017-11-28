using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e) { txt_valores.Text += 1; }
        private void btn_2_Click(object sender, EventArgs e) { txt_valores.Text += 2; }
        private void btn_3_Click(object sender, EventArgs e) { txt_valores.Text += 3; }
        private void btn_4_Click(object sender, EventArgs e) { txt_valores.Text += 4; }
        private void btn_5_Click(object sender, EventArgs e) { txt_valores.Text += 5; }
        private void btn_6_Click(object sender, EventArgs e) { txt_valores.Text += 6; }
        private void btn_7_Click_1(object sender, EventArgs e) { txt_valores.Text += 7; }
        private void btn_8_Click_1(object sender, EventArgs e) { txt_valores.Text += 8; }
        private void btn_9_Click(object sender, EventArgs e) { txt_valores.Text += 9; }
        private void btn_0_Click(object sender, EventArgs e) { txt_valores.Text += 0; }
        private void btn_punto_Click(object sender, EventArgs e) { txt_valores.Text += ","; }
        private void btn_sub_Click(object sender, EventArgs e) { txt_valores.Text += "-"; }
        private void btn_sum_Click(object sender, EventArgs e) { txt_valores.Text += "+"; }
        private void btn_div_Click(object sender, EventArgs e) { txt_valores.Text += "/"; }
        private void btn_mul_Click(object sender, EventArgs e) { txt_valores.Text += "*"; }
        private void btn_mod_Click(object sender, EventArgs e) { txt_valores.Text += "%"; }
        private void btn_sqrt_Click(object sender, EventArgs e) { txt_valores.Text += "sqrt"; }
        private void btn_pow_Click(object sender, EventArgs e) { txt_valores.Text += "^"; }
        private void btn_c_Click(object sender, EventArgs e) { txt_valores.Text = ""; }
        private void button1_Click(object sender, EventArgs e){txt_valores.Text += "log";}
        private void btn_igual_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            string aux = "";
            aux = txt_valores.Text;
            ServiceReferenceCliente.CalculadoraClient cal = new ServiceReferenceCliente.CalculadoraClient();
            if (aux.Contains("+"))
            {
                x = Double.Parse(aux.Substring(0, aux.IndexOf("+")));
                y = Double.Parse(aux.Substring(aux.IndexOf("+") + 1, (aux.Length - (aux.IndexOf("+") + 1))));
                x = cal.sum(x, y);


                txt_valores.Text = x.ToString();
            }
            else if (aux.Contains("-"))
            {

                x = Double.Parse(aux.Substring(0, aux.IndexOf("-")));
                y = Double.Parse(aux.Substring(aux.IndexOf("-") + 1, (aux.Length - (aux.IndexOf("-") + 1))));

                x = cal.sub(x, y);
                txt_valores.Text = x.ToString();
            }
            else if (aux.Contains("*"))
            {
                x = Double.Parse(aux.Substring(0, aux.IndexOf("*")));
                y = Double.Parse(aux.Substring(aux.IndexOf("*") + 1, (aux.Length - (aux.IndexOf("*") + 1))));
                x = cal.mult(x, y);
                txt_valores.Text = x.ToString();
            }
            else if (aux.Contains("/"))
            {
                x = Double.Parse(aux.Substring(0, aux.IndexOf("/")));
                y = Double.Parse(aux.Substring(aux.IndexOf("/") + 1, (aux.Length - (aux.IndexOf("/") + 1))));
                x = cal.div(x, y);
                txt_valores.Text = x.ToString();
            }
            else if (aux.Contains("%"))
            {
                x = Double.Parse(aux.Substring(0, aux.IndexOf("%")));
                y = Double.Parse(aux.Substring(aux.IndexOf("%") + 1, (aux.Length - (aux.IndexOf("%") + 1))));
                x = cal.mod(x, y);
                txt_valores.Text = x.ToString();
            }
            else if (aux.Contains("sqrt"))
            {
                if (aux.IndexOf("t") == 3)
                {
                    x = Double.Parse(aux.Substring(4, (aux.Length - 4)));
                    x = cal.sqt(x);
                    txt_valores.Text = x.ToString();
                }
                else
                {
                    x = Double.Parse(aux.Substring(0, aux.IndexOf("s")));
                    x = cal.sqt(x);
                    txt_valores.Text = x.ToString();
                }

            }
            else if (aux.Contains("^"))
            {
                x = Double.Parse(aux.Substring(0, aux.IndexOf("^")));
                y = Double.Parse(aux.Substring(aux.IndexOf("^") + 1, (aux.Length - (aux.IndexOf("^") + 1))));
                x = cal.pow(x, y);
                txt_valores.Text = x.ToString();
            }
            else if (aux.Contains("log"))
            {
                if (aux.IndexOf("g") == 2)
                {
                    x = Double.Parse(aux.Substring(3, (aux.Length - 3)));
                    x = cal.log(x);
                    txt_valores.Text = x.ToString();
                }
                else
                {
                    x = Double.Parse(aux.Substring(0, aux.IndexOf("l")));
                    x = cal.log(x);
                    txt_valores.Text = x.ToString();
                }

            }

        }
    }

}
