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
            return 1;//returning 1 so that it doesn't crash, this search does not get used but must return to avoid errors
        }
        public virtual void Display(int Result)//Default display for all search algorithms
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
