namespace Task5Galanida
{
    public partial class Form1Task5 : Form
    {
        public Form1Task5()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayArr_Click(object sender, EventArgs e)
        {
            int[] arrUnsortedNumbers = { 4, 3, 2, 1, 5 };
            listBoxNumbers.DataSource = null;
            listBoxNumbers.DataSource = arrUnsortedNumbers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
