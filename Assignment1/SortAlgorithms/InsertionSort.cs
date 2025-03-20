using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SortAlgorithms
{
    class InsertionSort : Sort
    {
        public override List<int> Ascending(List<int> Array)
        {
            int ArrayLength = Array.Count;
            for (int i = 1; i < ArrayLength; i++)
            {
                int Key = Array[i]; //Current element being considered
                int j = i - 1;
                while (j >= 0 && Array[j] > Key)
                {
                    Array[j + 1] = Array[j];
                    j = j - 1;
                }
                Array[j + 1] = Key;
            }
            return Array;
        }
        public override List<int> Descending(List<int> Array)
        {
            int ArrayLength = Array.Count;
            for (int i = 1; i < ArrayLength; i++)
            {
                int Key = Array[i]; //Current element being considered
                int j = i - 1;
                while (j >= 0 && Array[j] < Key)
                {
                    Array[j + 1] = Array[j];
                    j = j - 1;
                }
                Array[j + 1] = Key;
            }
            return Array;
        }
    }

}
