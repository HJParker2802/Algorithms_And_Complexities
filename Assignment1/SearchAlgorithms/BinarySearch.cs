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
        public int ClosestValue = -1;
        public int ClosestIndex = -1;
        public int ClosestDiff = int.MaxValue;

        public override List<int> SearchKey(List<int> Array,int Start, int Stop, int Key)
        {
            if (!(Array.Contains(Key)))
            {
                OutOfBounds = true;
                return SearchForClosestValue(Array, Start, Stop, Key);//if key not found in array, find closest value 
            }
            else
            {
                if (Start > Stop) return Result;//if start > stop, code cannot correctly run 

                int Mid = (Start + Stop) / 2;//Calculate Middle Index of Array
                int CheckValue = Array[Mid];//Value at Middle Index
                

                if (Key == CheckValue)//If key == CheckValue, match found
                {
                    Result.Add(Mid);  

                    //Check for duplicates on left of middle element
                    int left = Mid - 1;
                    while (left >= 0 && Array[left] == Key)
                    {
                        Result.Add(left);
                        left--;//move to next index on left
                    }

                    //Check for duplicates on right of middle element
                    int right = Mid + 1;
                    while (right < Array.Count && Array[right] == Key)
                    {
                        Result.Add(right);
                        right++;//Move to next index on right 
                    }
                }

                else
                {
                    if (Key < CheckValue)//if key is smaller than checkvalue, search left half of array
                    {
                        return SearchKey(Array, Start, Mid - 1, Key);
                    }
                    else//if key is larger than checkvalue, search right half of array 
                    {
                        return SearchKey(Array, Mid +1, Stop, Key);
                    }
                }
            }
            if (OutOfBounds)
            {
                Result.Add(ClosestIndex); //Ensures that if no key is found, the closest value is found and returned 
            }
            return Result;
        }
        public override List<int> SearchForClosestValue(List<int> Array, int Start, int Stop, int Key)
        {
            if (Start > Stop)//if start > stop, code cannot correctly run so return result
            {
                if (ClosestValue != -1)//if closest index found, add it
                {
                    Result.Add(ClosestIndex);//adds closest index
                }
                return Result;
            }

            int Mid = (Start + Stop) / 2;//Calculate Middle Index of Array
            int CheckValue = Array[Mid];//Value at Middle Index

            int CurrentDiff = Math.Abs(CheckValue - Key);//Checks for absolute difference to ensure positive or negative difference is ignored
            if (CurrentDiff < ClosestDiff)//if current difference smaller than closest difference,
                                          //update closeset diff, value and index 
            {
                ClosestDiff = CurrentDiff;
                ClosestValue = CheckValue;
                ClosestIndex = Mid;
            }

            if (Key < CheckValue)//if key smaller than current middle, search left half of array
            {
                return SearchForClosestValue(Array, Start, Mid - 1, Key);
            }
            else//if key larger than current middle, search left half of array
            {
                return SearchForClosestValue(Array, Mid + 1, Stop, Key);
            }
        }
    }
}
