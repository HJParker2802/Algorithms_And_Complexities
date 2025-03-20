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
        public virtual void Display(List<int> Array)
        {
            if (Array[0] > Array[Array.Count-1])
            {
                Console.Write("Descending: ");
            }
            else if (Array[0] < Array[Array.Count-1])
            {
                Console.Write("Ascending: ");
            }
            for (int x = 0; x <= Array.Count - 1; x++)
            {
                Console.Write(Array[x]);
                Console.Write(", ");
            }
            Console.Write("\b\b \n");//Sends log text backwards from the space to the comma and then overrides the comma with a space
        }
    }
}
