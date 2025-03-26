using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SearchAlgorithms
{
    class SequentialSearch : Searching
    {
        public override List<int> SearchKey(List<int> Array, int Start, int Stop, int Key)
        {
            List<int> Result = new List<int>();
            OutOfBounds = false;
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return SearchForClosestValue(Array, 0, Array.Count, Key);//If value is out of bounds, find closest value 
            }
            else
            {//if key is found, iterate through whole Array
                for (int i = 0; i < Array.Count; i++)
                {
                    if (Array[i] == Key)  //Check if current element matches Key being looked for 
                    {
                        Result.Add(i);//If it is, add it to results 
                    }
                }
            }
            return Result;
        }
        public override List<int> SearchForClosestValue(List<int> Array, int Start, int Stop, int Key)
        {
            List<int> Result = new List<int>();

            int ClosestValue = -1;  
            int ClosestIndex = -1;  
            int ClosestDiff = Array.Count;  

            //Loop through array to find closest value to the key
            for (int i = 0; i < Array.Count; i++)
            {
                int currentDiff = Math.Abs(Array[i] - Key);  //Absolute difference is used to ensure that it
                                                             //does not matter if it is bigger or smaller
                                                             //thatn the key, as long as it is the closest value

                if (currentDiff < ClosestDiff)//if current difference is smaller than the previous closest
                                              //difference update the value, index and difference
                {
                    ClosestDiff = currentDiff;
                    ClosestValue = Array[i];
                    ClosestIndex = i;
                }
            }

            
            if (ClosestValue != -1)//if closest value is found and not -1 (Used to throw an error where Results was -1)
            {//Add closest index to result 
                Result.Add(ClosestIndex);  
            }

            return Result;
        }
    }
}
