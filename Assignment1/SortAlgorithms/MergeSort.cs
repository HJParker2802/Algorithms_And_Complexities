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
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int Middle = Array.Count / 2;
            for (int i = 0; i < Middle; i++)
            {
                Left.Add(Array[i]);
            }
            for (int i = Middle; i < Array.Count; i++)
            {
                Right.Add(Array[i]);
            }
            Left = Ascending(Left);
            Right = Ascending(Right);
            return MergeAscending(Left, Right);
        }


        public static List<int> MergeAscending(List<int> Left, List<int> Right)
        {
            List<int> Result = new List<int>();

            while (Left.Count > 0 || Right.Count > 0)
            {
                if (Left.Count > 0 && Right.Count > 0)
                {
                    if (Left.First() <= Right.First())
                    {
                        Result.Add(Left.First());
                        Left.Remove(Left.First());
                    }
                    else
                    {
                        Result.Add(Right.First());
                        Right.Remove(Right.First());
                    }
                }
                else if (Left.Count > 0)
                {
                    Result.Add(Left.First());
                    Left.Remove(Left.First());
                }
                else if (Right.Count > 0)
                {
                    Result.Add(Right.First());
                    Right.Remove(Right.First());
                }
            }
            return Result;
        }

        public override List<int> Descending(List<int> Array)
        {
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int Middle = Array.Count / 2;
            for (int i = 0; i < Middle; i++)
            {
                Left.Add(Array[i]);
            }
            for (int i = Middle; i < Array.Count; i++)
            {
                Right.Add(Array[i]);
            }
            Left = Descending(Left);
            Right = Descending(Right);
            return MergeDescending(Left, Right);
        }

        public static List<int> MergeDescending(List<int> Left, List<int> Right)
        {
            List<int> Result = new List<int>();

            while (Left.Count > 0 || Right.Count > 0)
            {
                if (Left.Count > 0 && Right.Count > 0)
                {
                    if (Left.First() >= Right.First())
                    {
                        Result.Add(Left.First());
                        Left.Remove(Left.First());
                    }
                    else
                    {
                        Result.Add(Right.First());
                        Right.Remove(Right.First());
                    }
                }
                else if (Left.Count > 0)
                {
                    Result.Add(Left.First());
                    Left.Remove(Left.First());
                }
                else if (Right.Count > 0)
                {
                    Result.Add(Right.First());
                    Right.Remove(Right.First());
                }
            }
            return Result;
        }


    }
}
