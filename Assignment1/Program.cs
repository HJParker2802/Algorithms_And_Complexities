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
            int[] Arr = {1,3,2,5,4 };
            BubbleSort Test = new BubbleSort();
            Test.Ascending(Arr);
            Test.Display(Arr);
            Test.Descending(Arr);
            Test.Display(Arr);
        }
    }
}
