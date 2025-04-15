namespace 點餐
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

        public static string msg = "";
        public static double price = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); //建立FrmMenu的視窗，並命名為f1
            f2.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Text = msg;
        }
    }
}