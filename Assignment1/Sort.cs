using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Sort
    {
        public int comparisons;
        public int swaps;
        public virtual List<int> Ascending(List<int> Array)
        {
            Console.WriteLine("Ascending");
            return Array;
        }
        public virtual List<int> Descending(List<int> Array)
        {
            Console.WriteLine("Descending");
            return Array;
        }
        public virtual void Display(List<int> Array)//Default display for all sorting algorithms to display
        {
            if (Array[0] > Array[Array.Count - 1])
            {
                Console.Write("Descending: ");
            }
            else if (Array[0] < Array[Array.Count - 1])
            {
                Console.Write("Ascending: ");
            }
            for (int x = 0; x <= Array.Count - 1; x++)
            {
                Console.Write(Array[x]);
                Console.Write(", ");
            }
            Console.Write("\b\b \n\n");//Sends log text backwards from the space to the comma and then overrides the comma with a space
            Console.WriteLine($"Comparisons:{comparisons}, Swaps:{swaps}");//Displays comparisons and swaps made per display call

        }
        public virtual void DisplayEverySet(List<int> Array, int value)//Default display for all sorting algorithms to display
        {
            if (Array[0] > Array[Array.Count - 1])
            {
                Console.Write("Descending: ");
            }
            else if (Array[0] < Array[Array.Count - 1])
            {
                Console.Write("Ascending: ");
            }
            for (int x = 0; x <= Array.Count - 1; x++)
            {
                if (x%value == 0)//Makes it display every set number, for some its 10, some 50
                {
                    Console.Write(Array[x]);
                    Console.Write(", ");
                }
            }
            Console.Write("\b\b \n\n");//Sends log text backwards from the space to the comma and then overrides the comma with a space
            Console.WriteLine($"Comparisons:{comparisons}, Swaps:{swaps}");//Displays comparisons and swaps made per display call

        }

    }
}
