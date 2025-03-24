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
            OutOfBounds = false;
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return SearchForClosestValue(Array, 0, Array.Count, Key) ;
            }
            else
            {
                for (int i = 0; i < Array.Count; i++)
                {
                    if (Array[i] == Key)  
                    {
                        Result.Add(i);
                    }
                }
            }
            return Result;
        }
        public override List<int> SearchForClosestValue(List<int> Array, int start, int stop, int Key)
        {
            List<int> Result = new List<int>();

            int closestValue = -1;  
            int closestIndex = -1;  
            int closestDiff = Array.Count;  

            
            for (int i = 0; i < Array.Count; i++)
            {
                int currentDiff = Math.Abs(Array[i] - Key);  

                if (currentDiff < closestDiff)
                {
                    closestDiff = currentDiff;
                    closestValue = Array[i];
                    closestIndex = i;
                }
            }

            
            if (closestValue != -1)
            {
                Result.Add(closestIndex);  
            }

            return Result;
        }
    }
}
