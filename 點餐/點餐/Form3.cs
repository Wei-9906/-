using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 點餐
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += "＝＝＝＝＝＝＝＝＝＝" + Environment.NewLine;
            if (checkBox1.Checked)
            {
                Form1.price = Form1.price * 0.95;
                Form1.msg += "會員95折";
            }
            if (checkBox1.Checked)
            {
                Form1.price = Form1.price -20;
                Form1.msg += "折扣20元";
            }
            this.Dispose();
            Form1.msg += "實收" + Form1.price + Environment.NewLine;
        }
    }
}
