namespace Task5Descend
{
    public partial class Form1 : Form
    {

        int[] arrUnsortNum = {3,5,2,1,4};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBoxNums.DataSource = null;
            listBoxNums.DataSource = arrUnsortNum;
        }

        private void btnDescend_Click(object sender, EventArgs e)
        {
            ArraySorter input = new ArraySorter(arrUnsortNum);

            listBoxNums.DataSource = null;
            listBoxNums.DataSource = input.Sort();

        }
    }
}
