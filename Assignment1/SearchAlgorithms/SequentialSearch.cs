using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SearchAlgorithms
{
    class SequentialSearch : Searching
    {
        public override List<int> SearchKey(List<int> Array, int start, int stop, int Key)
        {
            List<int> Result = new List<int>();
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return Result;
            }
            else if (start < 0 || stop >= Array.Count || start > stop)
            {
                OutOfBounds = true;
                return Result;
            }
            else
            {
                for (int i = start; i <= stop; i++)  // Iterate from start to stop indices
                {
                    if (Array[i] == Key)
                    {
                        Result.Add(i);  // Add the index to the result list if the key matches
                    }
                }
            }
            return Result;
        }
    }
}
