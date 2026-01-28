

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFunction(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * RecursiveFunction(n - 1);
        }

        public int RecursiveSum(int[] num, int length)
        {
            if (length == 0)
            {
                return num[0];
            }
            return num[length] + RecursiveSum(num, length - 1);
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(inputFibBox.Text);
            int result = RecursiveFunction(num);
            labelFibResult.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[] numbers = inputSumBox.Text.Split(',').Select(int.Parse).ToArray();
            int resultSum = RecursiveSum(numbers, numbers.Length - 1);
            labelSumResult.Text = $"Sum: {resultSum}";
        }
    }
}
