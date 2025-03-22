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
        public virtual List<int> SearchKey(List<int> Array, int start, int stop, int Key)
        {
            List<int> Result = new List<int>();
            return Result;//returning 1 so that it doesn't crash, this search does not get used but must return to avoid errors
        }
        public virtual void Display(List<int> Result)
        {
            if (!OutOfBounds && Result.Count > 1)
            {
                Console.WriteLine($"The key was found at the following indeces: ");
                foreach (var index in Result)
                {
                    Console.WriteLine($"Index: {index}, Value: {index + 1} in the list");
                }
                //for (int index = 0; index < Result.Count; index++)
                //{
                //    Console.Write($"index: {index}, ");
                //}
                //Console.WriteLine($"\n\n\n");
            }
            else if (!OutOfBounds && Result.Count > 0)
            {
                Console.WriteLine($"The key was found at the following indeces: ");
                for (int index = 0; index < Result.Count; index++)
                {
                    Console.WriteLine($"Index: {index}");
                }

                Console.WriteLine($"\n\n\n");
            }
            else if (OutOfBounds)
            {
                Console.WriteLine("Input number was out of bounds");
            }
            else
            {
                Console.WriteLine("Something went wrong finding the Key");
            }
        }

    }
}
