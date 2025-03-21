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
                //Creating Read Object
                FileReader read = new FileReader();

                //Creating the Sorting objects
                BubbleSort Bubble = new BubbleSort();
                InsertionSort Insertion = new InsertionSort();
                MergeSort Merge = new MergeSort();
                QuickSort Quick = new QuickSort();

                //Creating Lists that need sorting
                List<int> CurrentList = new List<int>();

                CurrentList = read.ReadFile("Share_1_256.txt");
                Console.Write($"Share1_256:");
                Console.WriteLine("Unsorted");
                DisplayUnsorted(CurrentList);
                Console.Write("\n\n\n");
                List<int> Share1_256_Sorted_Ascend = Bubble.Ascending(CurrentList);
                Bubble.Display(Share1_256_Sorted_Ascend);
                List<int> Share1_256_Sorted_Descend = Bubble.Descending(CurrentList);
                Console.Write("\n\n\n");
                Bubble.Display(Share1_256_Sorted_Descend);
                Console.Write("\n\n\n");

                CurrentList = read.ReadFile("Share_1_2048.txt");
                Console.Write($"Share1_2048:");
                Console.WriteLine("Unsorted");
                DisplayUnsorted(CurrentList);
                Console.Write("\n\n\n");
                List<int> Share1_2048_Sorted_Ascend = Bubble.Ascending(CurrentList);
                Bubble.Display(Share1_2048_Sorted_Ascend);
                List<int> Share1_2048_Sorted_Descend = Bubble.Descending(CurrentList);
                Console.Write("\n\n\n");
                Bubble.Display(Share1_2048_Sorted_Descend);
                Console.Write("\n\n\n");

                CurrentList = read.ReadFile("Share_2_256.txt");
                Console.Write($"Share2_256:");
                Console.WriteLine("Unsorted");
                DisplayUnsorted(CurrentList);
                Console.Write("\n\n\n");
                List<int> Share2_256_Sorted_Ascend = Insertion.Ascending(CurrentList);
                Insertion.Display(Share2_256_Sorted_Ascend);
                List<int> Share2_256_Sorted_Descend = Insertion.Descending(CurrentList);
                Console.Write("\n\n\n");
                Insertion.Display(Share2_256_Sorted_Descend);
                Console.Write("\n\n\n");


                CurrentList = read.ReadFile("Share_2_2048.txt");
                Console.Write($"Share2_2048:");
                Console.WriteLine("Unsorted");
                DisplayUnsorted(CurrentList);
                Console.Write("\n\n\n");
                List<int> Share2_2048_Sorted_Ascend = Merge.Ascending(CurrentList);
                Merge.Display(Share2_2048_Sorted_Ascend);
                List<int> Share2_2048_Sorted_Descend = Merge.Descending(CurrentList);
                Console.Write("\n\n\n");
                Merge.Display(Share2_2048_Sorted_Descend);
                Console.Write("\n\n\n");

                CurrentList = read.ReadFile("Share_3_256.txt");
                Console.Write($"Share3_256:");
                Console.WriteLine("Unsorted");
                DisplayUnsorted(CurrentList);
                Console.Write("\n\n\n");
                List<int> Share3_256_Sorted_Ascend = Quick.Ascending(CurrentList);
                Quick.Display(Share3_256_Sorted_Ascend);
                List<int> Share3_256_Sorted_Descend = Quick.Descending(CurrentList);
                Console.Write("\n\n\n");
                Quick.Display(Share3_256_Sorted_Descend);
                Console.Write("\n\n\n");

                CurrentList = read.ReadFile("Share_2_2048.txt");
                Console.Write($"Share3_2048:");
                Console.WriteLine("Unsorted");
                DisplayUnsorted(CurrentList);
                Console.Write("\n\n\n");
                List<int> Share3_2048_Sorted_Ascend = Insertion.Ascending(CurrentList);
                Insertion.Display(Share3_2048_Sorted_Ascend);
                List<int> Share3_2048_Sorted_Descend = Insertion.Descending(CurrentList);
                Console.Write("\n\n\n");
                Insertion.Display(Share3_2048_Sorted_Descend);
                Console.Write("\n\n\n");


                //Creating Search Lists
                List<int>SearchList= read.ReadFile("Share_2_2048.txt");
                List<int>SearchList2= read.ReadFile("Share_3_2048.txt");

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
