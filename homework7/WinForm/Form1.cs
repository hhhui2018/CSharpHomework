using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);

        //增加新订单
        private void button1_Click(object sender, EventArgs e)
        {
            AddOrder f2 = new AddOrder();
            f2.MdiParent = this;
            f2.Show();
            SetParent((int)f2.Handle, (int)this.Handle);
        }

        //修改订单信息
        private void button3_Click(object sender, EventArgs e)
        {
            ModifyOrder f3 = new ModifyOrder();
            f3.MdiParent = this;
            f3.Show();
            SetParent((int)f3.Handle, (int)this.Handle);
        }

        //删除订单
        public void RemoveOrder(uint orderId)
        {
            string s = textBox4.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "删除成功",
                "Title",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
                uint a = 0;
                string s = textBox4.Text;
                a = uint.Parse(s);
                RemoveOrder(a);
        }

        //订单查询
        public void QueryOrderById(uint orderId)
        {
            string b = textBox2.Text;
        }
        public void QueryOrdersByGoodsName(string goodsName)
        {
            string b = textBox1.Text;
        }
        public void GetOrdersByCustomerName(string customerName)
        {
            string b = textBox3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            uint c = 0;
            string b = textBox1.Text;
            string d = textBox3.Text;
            c = uint.Parse(b);
            QueryOrderById(c);
            QueryOrdersByGoodsName(b);
            GetOrdersByCustomerName(d);
            return;
            textBox3.Text = b;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
