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
            //Method to declare variables that can be changed later on with recursion
            Comparisons = 0;
            Swaps = 0;
            QuickSortAscending(Array, 0, Array.Count - 1);//Triggers necessary method 
            return Array;//returns sorted array at the end 
        }
        public void QuickSortAscending(List<int> Array, int Left, int Right)
        {
            int LeftPointer, RightPointer;
            int Middle, temp;
            LeftPointer = Left;
            RightPointer = Right;
            Middle = Array[(Left + Right) / 2];
            do
            {
                while ((Array[LeftPointer] < Middle) && (LeftPointer < Right))
                {
                    LeftPointer++;//Moves to the right while looking for number bigger than middle
                    Comparisons++;
                }
                while ((Middle < Array[RightPointer]) && (RightPointer > Left)) 
                {
                    RightPointer--;//Moves to the right looking for number smaller than middle
                    Comparisons++;
                }
                if (LeftPointer <= RightPointer)
                {
                    temp = Array[LeftPointer];
                    Array[LeftPointer] = Array[RightPointer];
                    Array[RightPointer] = temp;//Swaps Left and Right Pointers
                    Swaps++;
                    LeftPointer++;
                    RightPointer--;
                }
            } while (LeftPointer <= RightPointer);
            if (Left < RightPointer) QuickSortAscending(Array, Left, RightPointer);//Sorts the left part
            if (LeftPointer < Right) QuickSortAscending(Array, LeftPointer, Right);//Sorts the right part
        }   
        public override List<int> Descending(List<int> Array)
        {
            Comparisons = 0;
            Swaps = 0;
            QuickSortDescending(Array, 0, Array.Count - 1);
            return Array;//returns sorted array at the end 
        }
        public void QuickSortDescending(List<int> Array, int left, int right)
        {
            int LeftPointer, RightPointer;
            int Middle, temp;
            LeftPointer = left;
            RightPointer = right;
            Middle = Array[(left + right) / 2];
            do
            {
                while ((Array[LeftPointer] > Middle) && (LeftPointer < right)) 
                {
                    LeftPointer++;//Moves to the right while looking for number bigger than middle
                    Comparisons++;
                }
                while ((Middle > Array[RightPointer]) && (RightPointer > left)) 
                {
                    RightPointer--;//Moves to the right looking for number smaller than middle
                    Comparisons++;
                }
                if (LeftPointer <= RightPointer)
                {
                    temp = Array[LeftPointer];
                    Array[LeftPointer] = Array[RightPointer];
                    Array[RightPointer] = temp;//Swaps Left and Right Pointers
                    Swaps++;
                    LeftPointer++;
                    RightPointer--;
                }
            } while (LeftPointer <= RightPointer);
            if (left < RightPointer) QuickSortDescending(Array, left, RightPointer);//Sorts the left part
            if (LeftPointer < right) QuickSortDescending(Array, LeftPointer, right);//Sorts the right part
        }
    }
}
