using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public bool check;
        public string func, firstNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b1.Text;
            else
            {
                tbScreen.Text = b1.Text;
                check = true;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b2.Text;
            else
            {
                tbScreen.Text = b2.Text;
                check = true;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b3.Text;
            else
            {
                tbScreen.Text = b3.Text;
                check = true;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b4.Text;
            else
            {
                tbScreen.Text = b4.Text;
                check = true;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b5.Text;
            else
            {
                tbScreen.Text = b5.Text;
                check = true;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b6.Text;
            else
            {
                tbScreen.Text = b6.Text;
                check = true;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b7.Text;
            else
            {
                tbScreen.Text = b7.Text;
                check = true;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b8.Text;
            else
            {
                tbScreen.Text = b8.Text;
                check = true;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b9.Text;
            else
            {
                tbScreen.Text = b9.Text;
                check = true;
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (check == true)
                tbScreen.Text += b0.Text;
            else
            {
                tbScreen.Text = b0.Text;
                check = true;
            }
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            firstNum = tbScreen.Text;
            tbScreen.Text = "";
            func = "+";
        }

        private void bMin_Click(object sender, EventArgs e)
        {
            firstNum = tbScreen.Text;
            tbScreen.Text = "";
            func = "-";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            firstNum = tbScreen.Text;
            tbScreen.Text = "";
            func = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            firstNum = tbScreen.Text;
            tbScreen.Text = "";
            func = "/";
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            tbScreen.Text = String.Empty;
            check = true;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            tbScreen.Enabled = true;
            tbScreen.Text = "";
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            tbScreen.Text = "\r\n" + Convert.ToString(System.Math.Sqrt(Convert.ToDouble(tbScreen.Text)));
            check = false;
        }

        private void bSin_Click(object sender, EventArgs e)
        {
            tbScreen.Text = "\r\n" + Convert.ToString(System.Math.Sin(
                (Convert.ToDouble(System.Math.PI) / 180) * Convert.ToDouble(tbScreen.Text)));
            check = false;
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            tbScreen.Text = "\r\n" + Convert.ToString(System.Math.Cos(
                (Convert.ToDouble(System.Math.PI) / 180) * Convert.ToDouble(tbScreen.Text)));
            check = false;
        }

        private void bTg_Click(object sender, EventArgs e)
        {

            tbScreen.Text = "\r\n" + Convert.ToString(System.Math.Tan(
                (Convert.ToDouble(System.Math.PI) / 180) * Convert.ToDouble(tbScreen.Text)));
            check = false;
        }

        private void bExp_Click(object sender, EventArgs e)
        {
            firstNum = tbScreen.Text;
            tbScreen.Text = "";
            func = "^";
        }

        private void bDecimal_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                tbScreen.Text += bDecimal.Text;
            }
            else
            {
                tbScreen.Text = bDecimal.Text;
                check = true;
            }
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            switch (func)
            {
                case "+":
                    tbScreen.Text = "\r\n" + Convert.ToString(Convert.ToInt32(firstNum) 
                        + Convert.ToInt32(tbScreen.Text));
                    break;
                case "-":
                    tbScreen.Text = "\r\n" + Convert.ToString(Convert.ToInt32(firstNum) 
                        - Convert.ToInt32(tbScreen.Text));
                    break;
                case "*":
                    tbScreen.Text = "\r\n" + Convert.ToString(Convert.ToInt32(firstNum) 
                        * Convert.ToInt32(tbScreen.Text));
                    break;
                case "/":
                    if (tbScreen.Text == "0")
                    {
                        tbScreen.Text = "\r\n NaN";
                    }
                    else
                    {
                        tbScreen.Text = "\r\n" + Convert.ToString(Convert.ToDecimal(firstNum) 
                            / Convert.ToInt32(tbScreen.Text));
                    }
                    break;
                case "^":
                    tbScreen.Text = "\r\n" + Convert.ToString(System.Math.Pow(Convert.ToInt32(firstNum), 
                        Convert.ToInt32(tbScreen.Text)));
                    break;
            }
            check = false;
        }

    }
}
