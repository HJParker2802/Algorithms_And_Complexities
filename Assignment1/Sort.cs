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
        public virtual int[] Ascending(int[] Array)
        {
            Console.WriteLine("Ascending");
            return Array;
        }
        public virtual int[] Descending(int[] Array)
        {
            Console.WriteLine("Descending");
            return Array;
        }
        public virtual void Display(int[] Array)
        {
            for (int x = 0; x <= Array.Length - 1; x++)
            {
                Console.Write(Array[x]);
                Console.Write(", ");
            }
            Console.Write("\b\b \n");//Sends log text backwards from the space to the comma and then overrides the comma with a space
        }
    }
}
