using System;
using System.CodeDom.Compiler;
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
        public int closestValue = -1;
        public int closestIndex = -1;
        public int closestDiff = int.MaxValue;
        public override List<int> SearchKey(List<int> Array,int start, int stop, int Key)
        {
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return SearchForClosestValue(Array, start, stop, Key);
            }
            else
            {
                if (start > stop) return Result;
                int mid = (start + stop) / 2;
                int CheckValue = Array[mid];
                if (Key == CheckValue)
                {
                    Result.Add(mid);  

                    int left = mid - 1;
                    while (left >= 0 && Array[left] == Key)
                    {
                        Result.Add(left);
                        left--;
                    }

                    int right = mid + 1;
                    while (right < Array.Count && Array[right] == Key)
                    {
                        Result.Add(right);
                        right++;
                    }
                }

                else
                {
                    if (Key < CheckValue)
                    {
                        return SearchKey(Array, start, mid - 1, Key);
                    }
                    else
                    {
                        return SearchKey(Array, mid + 1, stop, Key);
                    }
                }
            }
            if (OutOfBounds)
            {
                Result.Add(closestIndex); 
            }
            return Result;

        }
        public override List<int> SearchForClosestValue(List<int> Array, int start, int stop, int Key)
        {
            if (start > stop)
            {
                if (closestValue != -1)
                {
                    Result.Add(closestIndex);
                }
                return Result;
            }

            int mid = (start + stop) / 2;
            int CheckValue = Array[mid];

            int currentDiff = Math.Abs(CheckValue - Key);
            if (currentDiff < closestDiff)
            {
                closestDiff = currentDiff;
                closestValue = CheckValue;
                closestIndex = mid;
            }

            if (Key < CheckValue)
            {
                return SearchForClosestValue(Array, start, mid - 1, Key);
            }
            else
            {
                return SearchForClosestValue(Array, mid + 1, stop, Key);
            }
        }
    }
}
