namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EC eC = new EC();
            eC.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C f2 = new C();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MCon mCon = new MCon();
            mCon.ShowDialog();
        }
    }
}