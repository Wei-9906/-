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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[] dishPrice = { 90, 50, 70, 50 };
        int[] dessertPrice = { 30, 20, 40 };
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += comboBox1.Text + "\r\t" + dishPrice[comboBox1.SelectedIndex] + Environment.NewLine;
            Form1.msg += comboBox2.Text + "\r\t" + dessertPrice[comboBox2.SelectedIndex] + Environment.NewLine;
            Form1.price = dishPrice[comboBox1.SelectedIndex] + dessertPrice[comboBox2.SelectedIndex];
            Form1.msg += "合計" + Form1.price + Environment.NewLine;
            this.Dispose();
            Form3 f3 = new Form3(); //建立FrmMenu的視窗，並命名為f1
            f3.ShowDialog();
        }
    }
}
