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
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Array = new List<int>() {12,84,7,13,47,82,94,118,17289082, 98, 182, 882, 28, 828, 288, 17};
            MergeSort Merge = new MergeSort();
            List<int> Array2 = new List<int>() {1,2,3,4,5 };
            Merge.Ascending(Array2);
            Merge.Display(Array2);
        }
    }
}
