using System.ComponentModel;

namespace Lab2Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int FibPlaceFunction(int fibNum)
        {
            if (fibNum <= 1)
            {
                return fibNum;
            }

            return FibPlaceFunction(fibNum - 1) + FibPlaceFunction(fibNum - 2);
        }

        private void btnFibPlace_Click(object sender, EventArgs e)
        {
            int fibNum = int.Parse(textFibPlaceInput.Text);
            int result = FibPlaceFunction(fibNum);
            lblFibResult.Text = result.ToString();
        }


        private int ExponentCalculator (int baseNum, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            return baseNum * ExponentCalculator(baseNum, exponent - 1);
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(textBaseNum.Text);
            int expoNum = int.Parse(textExponentBox.Text);

            int result = ExponentCalculator(baseNum, expoNum);

            lblExpoResult.Text = result.ToString();
        }
    }
}
