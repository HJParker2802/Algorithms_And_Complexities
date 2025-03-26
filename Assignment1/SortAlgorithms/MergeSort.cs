using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SortAlgorithms
{
    class MergeSort : Sort
    {
        public override List<int> Ascending(List<int> Array)
        {
            Comparisons = 0;
            Swaps = 0;
            //if list has 1 or fewer elements, its already sorted
            if (Array.Count <= 1)
            {
                return Array;
            }
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int Middle = Array.Count / 2;
            for (int i = 0; i < Middle; i++)
            {
                Left.Add(Array[i]);//Add first half of list to Left list
            }
            for (int i = Middle; i < Array.Count; i++)
            {
                Right.Add(Array[i]);//Add second half of list to right list 
            }
            Left = Ascending(Left);
            Right = Ascending(Right);
            return MergeAscending(Left, Right);//Merge the two halves into one sorted array
        }

        public List<int> MergeAscending(List<int> Left, List<int> Right)
        {
            List<int> Result = new List<int>();//Will hold merged sorted array

            while (Left.Count > 0 || Right.Count > 0)//While either left or right list have values, keep merging until they're gone
            {
                if (Left.Count > 0 && Right.Count > 0)//While both left and right have values, keep merging until gone
                {
                    Comparisons++;
                    if (Left.First() <= Right.First())// <= for ascending
                    {
                        Result.Add(Left.First());
                        Left.Remove(Left.First());
                        Swaps++;
                    }
                    else
                    {
                        Result.Add(Right.First());
                        Right.Remove(Right.First());
                        Swaps++;
                    }
                }
                else if (Left.Count > 0)//if only left has values, add until none left
                {
                    Result.Add(Left.First());
                    Left.Remove(Left.First());
                    Swaps++;
                }
                else if (Right.Count > 0)//if only right has values, add until none left
                {
                    Result.Add(Right.First());
                    Right.Remove(Right.First());
                    Swaps++;
                }
            }
            return Result;
        }

        public override List<int> Descending(List<int> Array)
        {
            Comparisons = 0;
            Swaps = 0;
            //if list has 1 or fewer elements, its already sorted
            if (Array.Count <= 1)
            {
                return Array;
            }
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int Middle = Array.Count / 2;
            for (int i = 0; i < Middle; i++)
            {
                Left.Add(Array[i]);//Add first half of Array into the list
            }
            for (int i = Middle; i < Array.Count; i++)
            {
                Right.Add(Array[i]);//Add second half of Array into the list 
            }
            Left = Descending(Left);
            Right = Descending(Right);
            return MergeDescending(Left, Right);//Merge the two sides into one sorted List
        }
        
        private List<int> MergeDescending(List<int> Left, List<int> Right)
        {
            List<int> Result = new List<int>();

            while (Left.Count > 0 || Right.Count > 0)//While either left or right Lists have values, keep sorting until empty
            {
                if (Left.Count > 0 && Right.Count > 0)//If both have values, do both left and right until gone
                {
                    Comparisons++;
                    if (Left.First() >= Right.First())// >= for descending
                    {
                        Result.Add(Left.First());
                        Left.Remove(Left.First());
                        Swaps++;
                    }
                    else
                    {
                        Result.Add(Right.First());
                        Right.Remove(Right.First());
                        Swaps++;
                    }
                }
                else if (Left.Count > 0)//If only left has values, Sort left
                {
                    Result.Add(Left.First());
                    Left.Remove(Left.First());
                    Swaps++;
                }
                else if (Right.Count > 0)//If only right has values, sort right
                {
                    Result.Add(Right.First());
                    Right.Remove(Right.First());
                    Swaps++;
                }
            }
            return Result;//Returns completed Arrays
        }
    }
}
