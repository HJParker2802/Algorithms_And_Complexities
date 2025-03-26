using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class BubbleSort : Sort
    {
        public override List<int> Ascending(List<int> Array)
        {
            Comparisons = 0;
            Swaps = 0;
            int ArrayCount = Array.Count;
            for (int i = 0; i < ArrayCount - 1; i++)//Runs for ArrayCount-1 iterations 
            {
                for (int j = 0; j < ArrayCount - 1 - i; j++)
                {
                    Comparisons++;
                    //< makes this ascending
                    if (Array[j + 1] < Array[j])//Check if next element is smaller than current
                    {//Swaps element if out of order
                        int temp = Array[j];//Stores element in temp variable
                        Array[j] = Array[j + 1];//Swap current element with next one
                        Array[j + 1] = temp;//Override next element with value of temp 
                        Swaps++;
                    }
                }
            }
            return Array;
        }
        public override List<int> Descending(List<int> Array)
        {
            Comparisons = 0;
            Swaps = 0;
            int ArrayCount = Array.Count;
            for (int i = 0; i < ArrayCount - 1; i++)//Runs for ArrayCount-1 iterations 
            {
                for (int j = 0; j < ArrayCount - 1 - i; j++)
                {
                    Comparisons++;
                    //< makes this descending
                    if (Array[j + 1] > Array[j])//Check if next element is smaller than current
                    {//Swaps element if out of order
                        int temp = Array[j];//Stores element in temp variable
                        Array[j] = Array[j + 1];//Swap current element with next one
                        Array[j + 1] = temp;//Override next element with value of temp 
                        Swaps++;
                    }
                }
            }
            return Array;
        }
    }
}
