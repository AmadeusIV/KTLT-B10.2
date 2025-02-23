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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxKQ.Text=textBox1.Text;
        }

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
            while (a != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private string UC()
        {
            return "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}