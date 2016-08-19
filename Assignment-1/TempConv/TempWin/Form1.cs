using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TempWin.TempConverter;

namespace TempWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempConverter.ServiceClient proxy = new TempConverter.ServiceClient();
            int num = Convert.ToInt32(this.textBox1.Text);
            this.label1.Text = "ANS = " + proxy.c2f(num).ToString() + " F";
            label1.Visible = true;
            proxy.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceClient proxy = new ServiceClient();
            int num = Convert.ToInt32(this.textBox2.Text);
            this.label2.Text = "ANS = " + proxy.f2c(num).ToString() + " C";
            label2.Visible = true;
            proxy.Close();
        }


    }
}
