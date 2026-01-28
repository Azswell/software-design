using System;
using System.Collections.Generic;
using System.Text;

namespace Task5Descend
{
    internal class ArraySorter
    {

        public ArraySorter(int[] arrUnsortNum)
        {
            this.numArray = arrUnsortNum;
        }
        public int[] numArray { get; set; }

        public int[] Sort()
        {
            bool swap;

            for (int i = 0; i < numArray.Length - 1; i++)
                {
                    swap = false;
                    for (int index = 0; index < numArray.Length - 1; index++)
                    {
                        if (numArray[index] < numArray[index + 1])
                        {
                            int temp = numArray[index];
                            numArray[index] = numArray[index + 1];
                            numArray[(index + 1)] = temp;
                      
                        swap = true;
                        }
                    }
                    if (swap == false)
                    {
                        break;
                    }
                }
            return numArray;
        }

        private void numSwap(ref int firstNum, ref int secondNum)
        {
            int temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

        }
    }
}
