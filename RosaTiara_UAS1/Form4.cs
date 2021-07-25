using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RosaTiara_UAS1
{
    public partial class Form4 : Form
    {
        public object Form4ActiveForm { get; private set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been paid by cash. Thank you so much for your order!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been paid by GoPay. Thank you so much for your order!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been paid by PayPal. Thank you so much for your order!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

       public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
