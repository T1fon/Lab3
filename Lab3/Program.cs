using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RomanNumber n1, n2;
            RomanNumber[] array = { new RomanNumber(10),
                new RomanNumber(2323), new RomanNumber(1000),
                new RomanNumber(3521),new RomanNumber(1),
                new RomanNumber(11),new RomanNumber(10)};

            n1 = new RomanNumber(2456);
            n2 = new RomanNumber(1123);

            Console.WriteLine("Unsorted array:");
            foreach (RomanNumber n in array)
            {
                Console.Write("{0} ", n.ToString());
            }
            Array.Sort(array);
            Console.WriteLine("\nSorted array:");
            foreach (RomanNumber n in array)
            {
                Console.Write("{0} ", n.ToString());
            }
            Console.WriteLine("");

            // n1: MMCDLVI
            // n2: MCXXIII
            Console.WriteLine("n1: {0}\nn2: {1}", (n1).ToString(), (n2).ToString());

            // n1+n2: MMMDLXXIX
            Console.WriteLine("n1+n2: {0}", (n1 + n2).ToString());

            // n1-n2: MCCCXXXIII
            Console.WriteLine("n1-n2: {0}", (n1 - n2).ToString());

            // n1/n2: II
            Console.WriteLine("n1/n2: {0}", (n1 / n2).ToString());

            try
            {
                Console.WriteLine("n1*n2: {0}", (n1 * n2).ToString());
            }
            catch (R_N_E e)
            {
                Console.WriteLine($"Found exception: {e.Message}");
            }
            finally
            {
                n1 = new RomanNumber(1509);
                n2 = new RomanNumber(2);
                // n1*n2: MMMXVIII
                Console.WriteLine("{0}*{1}: {2}", n1, n2, (n1 * n2).ToString());
            }
        }
    }
}