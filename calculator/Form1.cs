using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
                lbl_1.Text = "0+i";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "1+i";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "2+i";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "3+i";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "4+i";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "5+i";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "6+i";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "7+i";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "8+i";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_1.Text = Convert.ToString(9+i);
            i = Convert.ToInt32(lbl_1.Text);
        }
       
    }
}
