using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_PA1_CoreConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            #region Prob 1: Variables and Printing

            #region variable declarations

            // p.18 examples - declare doubles
            double doubleA = 0;
            System.Double doubleB = 0;
            // p. 71 example - declare double
            double doubleC = new double();

            #endregion

            #region variable initialization

            // declare and initialize variables of each numeric type
            byte byteD = 254;
            short shortE = 32_766;
            int intF = 24;
            long longG = 9_223_372_036_854_775_806;
            float floatH = 3.33f;
            double doubleI = 7.777777777777777;
            decimal decimalJ = 79.228_162_514_264_337_593_543_950_334m;

            // print variable values to the console screen
            Console.WriteLine("Variable values:");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-",35)));
            Console.WriteLine("Byte example => value of d : {0}", byteD);
            Console.WriteLine("Short example => value of e : {0:n}", shortE);
            Console.WriteLine("Int example => value of f : {0:d9}", intF);
            Console.WriteLine("Long example => value of g : {0:n}", longG);
            Console.WriteLine("Float example => value of h : {0}", floatH);
            Console.WriteLine("Double example => value of i : {0}", doubleI);
            Console.WriteLine("Decimal example => value of j : {0}", decimalJ);
            Console.WriteLine();

            #endregion

            #region Max/Min Values

            // print the Min and Max values of the above variables to the console screen
            Console.WriteLine("Min and Max Values:");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 35)));
            Console.Write("Byte example => MinValue of d : {0}", byte.MinValue, byteD);
            Console.WriteLine(" and MaxValue of d : {0}", byte.MaxValue, byteD);
            Console.Write("Short example => MinValue of e : {0}", short.MinValue, shortE);
            Console.WriteLine(" and MaxValue of e : {0}", short.MaxValue, shortE);
            Console.Write("Int example => MinValue of f : {0}", int.MinValue, intF);
            Console.WriteLine(" and MaxValue of f : {0}", int.MaxValue, intF);
            Console.Write("Long example => MinValue of g : {0}", long.MinValue, longG);
            Console.WriteLine(" and MaxValue of g : {0}", long.MaxValue, longG);
            Console.Write("Float example => MinValue of h : {0}", float.MinValue, floatH);
            Console.WriteLine(" and MaxValue of h : {0}", float.MaxValue, floatH);
            Console.Write("Double example => MinValue of i : {0}", double.MinValue, doubleI);
            Console.WriteLine(" and MaxValue of i : {0}", double.MaxValue, doubleI);
            Console.Write("Decimal example => MinValue of j : {0}", decimal.MinValue, decimalJ);
            Console.WriteLine(" and MaxValue of j : {0}", decimal.MaxValue, decimalJ);

            #endregion

            #endregion
        }
    }
}
