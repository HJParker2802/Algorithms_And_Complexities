using Assignment1.Search;
using Assignment1.SearchAlgorithms;
using Assignment1.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing Test = new Testing();
            Test.main();//This object tests that all sorting and searching classes are workings
            Console.Clear();


        }
        static void DisplayUnsorted(List<int> Array)
        {
            Console.Write("Unsorted: ");
            for (int x = 0; x <= Array.Count - 1; x++)
            {
                Console.Write(Array[x]);
                Console.Write(", ");
            }
            Console.Write("\b\b \n");//Sends log text backwards from the space to the comma and then overrides the comma with a space
        }

    }
}
