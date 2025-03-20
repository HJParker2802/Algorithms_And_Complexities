using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SortAlgorithms
{
    class QuickSort : Sort
    {
        public override List<int> Ascending(List<int> Array)
        {
            QuickSortAscending(Array, 0, Array.Count - 1);
            return Array;
        }
        public static void QuickSortAscending(List<int> Array, int Left, int Right)
        {
            int i, j;
            int pivot, temp;
            i = Left;
            j = Right;
            pivot = Array[(Left + Right) / 2];
            do
            {
                while ((Array[i] < pivot) && (i < Right)) i++;
                while ((pivot < Array[j]) && (j > Left)) j--;
                if (i <= j)
                {
                    temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (Left < j) QuickSortAscending(Array, Left, j);
            if (i < Right) QuickSortAscending(Array, i, Right);
        }
        public override List<int> Descending(List<int> Array)
        {
            QuickSortDescending(Array, 0, Array.Count - 1);
            return Array;
        }
        public static void QuickSortDescending(List<int> Array, int left, int right)
        {
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            pivot = Array[(left + right) / 2];
            do
            {
                while ((Array[i] > pivot) && (i < right)) i++;
                while ((pivot > Array[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) QuickSortDescending(Array, left, j);
            if (i < right) QuickSortDescending(Array, i, right);
        }
    }
}
