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

            }
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBoxKQ.Text = " ";
        }
        private int n;
        private int m;
        string UC()
        {

        }
        void UCLN() 
        {
        
        }
    }
}