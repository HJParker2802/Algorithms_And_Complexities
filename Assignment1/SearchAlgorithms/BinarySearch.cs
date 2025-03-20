using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1.Search
{
    class BinarySearch : Searching
    {
        public override int SearchKey(List<int> Array,int start, int stop, int Key)
        {
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return 0;
            }
            else
            {
                if (start > stop) return 0;
                int mid = (start + stop) / 2;
                if (Key == Array[mid])
                {
                    return mid;
                }
                else if (Key < Array[mid])
                {
                    return SearchKey(Array, start, mid - 1, Key);
                }
                else
                {
                    return SearchKey(Array, mid + 1, stop, Key);
                }
            }
        }
    }
}
