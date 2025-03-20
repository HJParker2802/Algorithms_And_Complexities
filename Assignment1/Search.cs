using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Searching
    {
        public bool OutOfBounds;
        public virtual int SearchKey(List<int> Array, int start, int stop, int Key)
        {
            return 1;
        }
        public virtual void Display(int Result)
        {
            if (!OutOfBounds)
            {
                Console.WriteLine($"The List Index was {Result}, it was number {Result+1} in the list");
            }
            else
            {
                Console.WriteLine("Input number was out of bounds");
            }
        }
        
    }
}
