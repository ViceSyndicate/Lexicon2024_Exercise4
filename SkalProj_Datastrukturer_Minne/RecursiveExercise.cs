using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class RecursiveExercise
    {
        public int RecursiveOdd(int n)
        {
            Console.WriteLine("N = " + n);
            if (n == 1)
            {
                return 1;
            }
            return (RecursiveOdd(n - 1) + 2);
        }

        public int RecursiveEven(int n)
        {
            Console.WriteLine("N = " + n);
            if (n == 2)
            {
                return 2;
            }
            return (RecursiveEven(n - 1) + 2);
        }
    }
}