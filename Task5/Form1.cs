//AN ARRAY USING BUBBLE SORT


namespace Task5
{

   
    public partial class Form1Task5 : Form
    {
        int[] arrUnsortNum = { 4, 3, 5, 1, 2 };
        public Form1Task5()
        {
            InitializeComponent();
        }


        private int[] BubbleSort(int[] arrInputNum)
        {
            bool swap;

            for(int i = 0; i < arrInputNum.Length - 1; i++)
            {
                swap = false;
                for (int index = 0; index < arrInputNum.Length - 1; index++)
                {
                    if (arrInputNum[index] > arrInputNum[index + 1])
                    {
                        int temp = arrInputNum[index];
                        arrInputNum[index] = arrInputNum[index + 1];
                        arrInputNum[index + 1] = temp;
                        swap = true;
                    }
                }
                if(swap == false)
                {
                    break;
                }
            }
            return arrInputNum;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] arrSortNum = BubbleSort(arrUnsortNum);
            listBoxNumbers.DataSource = null;
            listBoxNumbers.DataSource = arrSortNum;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBoxNumbers.DataSource = null;
            listBoxNumbers.DataSource = arrUnsortNum;
        }
    }
}
