using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SearchAlgorithms
{
    class SequentialSearch : Searching
    {
        public override int SearchKey(List<int> Array, int start, int stop, int Key)
        {
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return -1;
                
            }
            else
            {
                int i = 0;
                while (Array[i] != Key)
                {
                    i = i + 1;
                }
                if (i < stop) { return i; }
                else return -1;
            }
        }
    }
}
