using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class ModifyOrder : Form
    {
        public ModifyOrder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void QueryOrderById(uint orderId)
        {
            string b = textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            uint c = 0;
            string b = textBox1.Text;
            c = uint.Parse(b);
            QueryOrderById(c);
            return;
            textBox2.Text = b;
            textBox3.Text = b;
            textBox4.Text = b;
            textBox5.Text = b;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "保存成功",
                "Title",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

    }
}
