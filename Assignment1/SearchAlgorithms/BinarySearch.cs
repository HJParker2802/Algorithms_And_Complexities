using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1.Search
{
    class BinarySearch : Searching
    {
        public List<int> Result = new List<int>();
        public override List<int> SearchKey(List<int> Array,int start, int stop, int Key)
        {
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return Result;
            }
            else
            {
                if (start > stop) return Result;
                int mid = (start + stop) / 2;
                int CheckValue = Array[mid];
                if (Key == CheckValue)
                {
                    //return mid;

                    Result.Add(mid);  // Found the first occurrence, add the index

                    // Now check the left side for other occurrences
                    int left = mid - 1;
                    while (left >= 0 && Array[left] == Key)
                    {
                        Result.Add(left);
                        left--;
                    }

                    // Now check the right side for other occurrences
                    int right = mid + 1;
                    while (right < Array.Count && Array[right] == Key)
                    {
                        Result.Add(right);
                        right++;
                    }
                }

                else if (Key  < CheckValue)
                {
                    return SearchKey(Array, start, mid - 1, Key);
                }
                else
                {
                    return SearchKey(Array, mid + 1, stop, Key);
                }
                return Result;
            }
        }
    }
}
