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
            comparisons = 0;
            swaps = 0;
            int ArrayLength = Array.Count;
            for (int i = 1; i < ArrayLength; i++)
            {
                int Key = Array[i]; //Current element being considered
                int j = i - 1;
                while (j >= 0 && Array[j] > Key)
                {
                    comparisons++;
                    Array[j + 1] = Array[j];
                    swaps++;
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
                    comparisons++;
                    if (Array[i] > Key)
                    {
                        Array[j + 1] = Array[j];
                        swaps++;
                        j = j - 1;
                    }
                    else
                    {
                        break;
                    }
                }
                Array[j + 1] = Key;
            }
            return Array;
        }
    }

}
