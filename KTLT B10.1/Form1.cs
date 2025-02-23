using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTLT_B10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult o = MessageBox.Show("Ban muon thoat ko?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (o == DialogResult.Yes)
                this.Close();
        }
        
        private void buttonKQ_Click(object sender, EventArgs e)
        {
            if (rButtonUC.Checked)
            {
                if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b) && int.TryParse(textBox3.Text, out int c))
                {
                    int result = UCLN(UCLN(a, b), c);
                    textBoxKQ.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Vui long nhap so nguyen hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rButtonBC.Checked)
            {
                if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b) && int.TryParse(textBox3.Text, out int c))
                {
                    long temp1 = (long)a * b / UCLN(a, b);
                    long result = (temp1 * c) / UCLN((int)temp1, c);
                    textBoxKQ.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Vui long nhap so nguyen hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rButtonPTB1.Checked)
            {
                
                if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b))
                {
                    if (a == 0 && b == 0)
                    {
                        textBoxKQ.Text = "Phuong trinh vo so nghiem";
                    }
                    else if (a == 0 && b != 0)
                    {
                        textBoxKQ.Text = "Phuong trinh vo nghiem";
                    }
                    else
                    {
                        double result = (double)-b / a;
                        textBoxKQ.Text = result.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Vui long nhap so nguyen hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rButtonPTB2.Checked)
            {
                if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b) && int.TryParse(textBox3.Text, out int c))
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        textBoxKQ.Text = "Phuong trinh vo nghiem";
                    }
                    else if (delta == 0)
                    {
                        double result = (double)-b / (2 * a);
                        textBoxKQ.Text = result.ToString();
                    }
                    else
                    {
                        double result1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double result2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        textBoxKQ.Text = "x1 = " + result1.ToString() + " x2 = " + result2.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Vui long nhap so nguyen hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui long chon 1 trong 4 chuc nang", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBoxKQ.Text = " ";
        }
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        

        private void label6_Click(object sender, EventArgs e) { }

        private void textBoxKQ_TextChanged(object sender, EventArgs e) { }

        private void rButtonPTB1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox3.Visible = false;
        }

        private void rButtonUC_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox3.Visible = true;
        }

        private void rButtonBC_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox3.Visible = true;
        }

        private void rButtonPTB2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox3.Visible = true;
        }
    }
}