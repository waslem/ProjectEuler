using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger answer = 0, i = 1, max;
            // define the condition to stop calculating, in this case we want the first 1000 digit fib number.
            max = BigInteger.Pow(10, 999);

            CalculateOneThousandDigitFib(ref answer, ref i, ref max);
            
            Console.WriteLine("{0}, {1}", answer, i);
            Console.ReadLine();
        }

        private static void CalculateOneThousandDigitFib(ref BigInteger answer, ref BigInteger i, ref BigInteger max)
        {
            // while the answer we recieve from the current fibbonacci calc for i is less than 1000 digits
            // continue calculating 
            while (answer < max)
            {
                answer = FibbonacciIterative(i);
                //answer = Fibbonacci(i);
                if (answer < max)
                {
                    answer++;
                    i++;
                }
            }
        }

        // iterative method for calculating nth fibbonacci number
        // about 1000 times faster than recursive.
        public static BigInteger FibbonacciIterative(BigInteger n)
        {
            BigInteger a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                BigInteger temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        // recursive method for calculating the nth fibbonacci number.
        public static BigInteger Fibbonacci(BigInteger n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;
            else
                return (Fibbonacci(n - 1) + Fibbonacci(n - 2));
        }
    }
}
