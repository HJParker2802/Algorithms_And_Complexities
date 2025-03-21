using Assignment1.Search;
using Assignment1.SearchAlgorithms;
using Assignment1.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Testing
    {
        public void main()
        {
            {
                //Creating the Sorting objects
                BubbleSort Bubble = new BubbleSort();
                InsertionSort Insertion = new InsertionSort();
                MergeSort Merge = new MergeSort();
                QuickSort Quick = new QuickSort();

                //Creating Lists that need sorting
                List<int> Array_unsorted = new List<int>() { 12, 84, 7, 13, 47, 82, 94, 118, 17289082, 98, 182, 882, 28, 828, 288, 17 };
                List<int> Array2_unsorted = new List<int>() { 99, 46, 37, 93, 72, 4, 83, 82, 98585854, 292, 9 };
                List<int> Array3_unsorted = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 32, 34, 353 };
                List<int> Array4_unsorted = new List<int>() { 1, 2, 3, 4, 5, 9, 8, 7, 6 };

                Console.WriteLine("BubbleSort:");
                Console.Write("Unsorted: ");
                DisplayUnsorted(Array_unsorted);
                List<int> Array_Ascending = Merge.Ascending(Array_unsorted);
                List<int> Array_Descending = Merge.Descending(Array_unsorted);
                Merge.Display(Array_Ascending);
                Merge.Display(Array_Descending);
                Console.WriteLine();

                Console.WriteLine("InsertionSort:");
                Console.Write("Unsorted: ");
                DisplayUnsorted(Array2_unsorted);
                List<int> Array2_Ascending = Insertion.Ascending(Array2_unsorted);
                List<int> Array2_Descending = Insertion.Descending(Array2_unsorted);
                Insertion.Display(Array2_Ascending);
                Insertion.Display(Array2_Descending);
                Console.WriteLine();

                Console.WriteLine("MergeSort:");
                Console.Write("Unsorted: ");
                DisplayUnsorted(Array3_unsorted);
                List<int> Array3_Ascending = Merge.Ascending(Array3_unsorted);
                List<int> Array3_Descending = Merge.Descending(Array3_unsorted);
                Merge.Display(Array3_Ascending);
                Merge.Display(Array3_Descending);
                Console.WriteLine();

                Console.WriteLine("QuickSort:");
                Console.Write("Unsorted: ");
                DisplayUnsorted(Array4_unsorted);
                List<int> Array4_Ascending = Quick.Ascending(Array4_unsorted);
                List<int> Array4_Descending = Quick.Descending(Array4_unsorted);
                Quick.Display(Array4_Ascending);
                Quick.Display(Array4_Descending);
                Console.WriteLine();


                //Creating Search Lists
                List<int> SearchList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                List<int> SearchList2 = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                List<int> SearchList3 = new List<int>() { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

                //Declaring Objects
                BinarySearch Binary = new BinarySearch();
                SequentialSearch Sequential = new SequentialSearch();

                //Searching
                DisplayUnsorted(SearchList);
                int Key = 5;
                int Answer = Binary.SearchKey(SearchList, 0, SearchList.Count, Key);
                Console.WriteLine($"Looking for number:{Key}");
                Binary.Display(Answer);
                Console.WriteLine();

                DisplayUnsorted(SearchList2);
                int Key2 = 1;
                int Answer2 = Sequential.SearchKey(SearchList2, 0, SearchList2.Count, Key2);
                Console.WriteLine($"Looking for number:{Key2}");
                Binary.Display(Answer2);
                Console.WriteLine();

                DisplayUnsorted(SearchList3);
                int Key3 = 5;
                int Answer3 = Binary.SearchKey(SearchList3, 0, SearchList3.Count, Key3);
                Console.WriteLine($"Looking for number:{Key}");
                Binary.Display(Answer);
                Console.WriteLine();
            }
            void DisplayUnsorted(List<int> Array)
            {
                for (int x = 0; x <= Array.Count - 1; x++)
                {
                    Console.Write(Array[x]);
                    Console.Write(", ");
                }
                Console.Write("\b\b \n");//Sends log text backwards from the space to the comma and then overrides the comma with a space
            }
        }
    }
}
