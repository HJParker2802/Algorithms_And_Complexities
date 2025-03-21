﻿using System;
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
            comparisons = 0;
            swaps = 0;
            int n = Array.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    comparisons++;
                    if (Array[j + 1] < Array[j])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                        swaps++;
                    }
                }
            }
            return Array;
        }
        public override List<int> Descending(List<int> Array)
        {
            comparisons = 0;
            swaps = 0;
            int n = Array.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    comparisons++;
                    if (Array[j + 1] > Array[j])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                        swaps++;
                    }
                }
            }
            return Array;
        }
    }
}
