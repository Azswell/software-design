namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = {4,5,3,1,2};
            int[] sortedNumebers = ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumebers;
        }
    }
}
