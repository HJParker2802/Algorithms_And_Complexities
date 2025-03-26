using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Searching
    {
        public bool OutOfBounds;
        public virtual List<int> SearchKey(List<int> Array, int Start, int Stop, int Key)
        {
            List<int> Result = new List<int>();
            return Result;//Returns the result
        }
        public virtual List<int> SearchForClosestValue(List<int> Array, int Start, int Stop, int Key)
        {
            return Array;//Returns the array
        }

        public virtual void Display(List<int> Result)//If key not found, shows error message 
        {
            if (!OutOfBounds && Result.Count > 1)
            {
                Console.WriteLine($"The key was found at the following indeces: ");
                foreach (var Index in Result)
                {
                    Console.WriteLine($"Index: {Index}, Value: {Index + 1} in the list");
                }
            }
            else if (!OutOfBounds && Result.Count > 0)
            {
                Console.WriteLine($"The key was found at the following indeces: ");
                int Index = Result[0];
                Console.WriteLine($"Index: {Index}");


                Console.WriteLine($"\n");
            }
            else if (OutOfBounds)
            {
                Console.WriteLine("Input number was not found");
            }
            else
            {
                Console.WriteLine("Something went wrong finding the Key");
            }
        }
        public virtual void Display_Nearest(List<int> Result)//Shows found results and nearest results if key not found
        {
            if (!OutOfBounds && Result.Count > 1)//Set to display for all cases where the number is found more than once
            {
                Console.WriteLine($"The key was found at the following indeces: ");
                foreach (var Index in Result)
                {
                    Console.WriteLine($"Index: {Index} , Value:  {Index + 1} in the list");
                }
            }
            else if (!OutOfBounds && Result.Count > 0)//Set to display for all cases where the number is found once
            {
                Console.WriteLine($"The key was found at the following indeces: ");
                int Index = Result[0];
                Console.WriteLine($"Index: {Index}");


                Console.WriteLine($"\n");
            }
            else if (OutOfBounds)
            {
                Console.WriteLine("Input number was not found");
                Console.WriteLine($"Nearest value was: {Result[0]}");
            }
            else
            {
                Console.WriteLine("Something went wrong finding the Key");
            }
        }

    }
}
