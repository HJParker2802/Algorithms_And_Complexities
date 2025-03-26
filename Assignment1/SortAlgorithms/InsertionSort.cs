using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SortAlgorithms
{
    class InsertionSort : Sort
    {
        public override List<int> Ascending(List<int> Array)
        {
            Comparisons = 0;
            Swaps = 0;
            int ArrayLength = Array.Count;
            for (int i = 1; i < ArrayLength; i++)
            {
                int Key = Array[i]; //Current element being to be inserted 
                int j = i - 1;
                while (j >= 0 && Array[j] > Key)
                {// Array[j] < Key is what makes this ascending
                    Comparisons++;
                    Array[j + 1] = Array[j];//Shift the element to the right 
                    Swaps++;
                    j = j - 1;//Switch to the next element in the Array 
                }
                Array[j + 1] = Key;//Puts Key into the correct position
            }//Process repeats over and over again until fully sorted 
            return Array;//Returns sorted list 
        }   
        public override List<int> Descending(List<int> Array)
        {
            int ArrayLength = Array.Count;
            for (int i = 1; i < ArrayLength; i++)
            {
                int Key = Array[i]; //Current element being considered
                int j = i - 1;
                while (j >= 0 && Array[j] < Key)
                {// Array[j] < Key is what makes this descending
                    Comparisons++;
                    Array[j + 1] = Array[j];//Shift the element to the 
                    Swaps++;
                    j = j - 1;//Switch to the next element in the Arrayw
                }
                Array[j + 1] = Key;
            }
            return Array;
        }
    }

}
