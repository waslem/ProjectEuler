using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler10
{
    /* 
     * Project Euler problem # 10.
     * First attempt, takes ~ 90 seconds to calculate answer.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            List<int> Primes = CalculatePrimeList(2000000);
            timer.Stop();

            double seconds = (double)(timer.ElapsedMilliseconds / 1000.00);
            Console.WriteLine("Time elapsed: {0:F} seconds", seconds);
            //List<int> PrimesUptoN = CalculatePrimeListUnderNthLength(10);

            // need to use int64 or bigint as number overflows with normal int.
            BigInteger primeSum = SumPrimeList(Primes);
            //Int64 primeSum = SumPrimeList(Primes);

            Console.WriteLine("Sum of all primes upto 2million: {0}", primeSum);
            Console.ReadLine();
        }

        private static BigInteger SumPrimeList(List<int> Primes)
        {
            BigInteger primeSum = 0;

            foreach (int item in Primes)
            {
                primeSum += item;
            }

            return primeSum;

        }

        // calculates all the primes upto the nth prime.
        public static List<int> CalculatePrimeList(int n)
        {
            List<int> Primes = new List<int>();
            
            // start with first 2 primes, 
            Primes.Add(2);
            Primes.Add(3);

            for (int i = 5; i <= n; i+=2)
			{
                bool isPrime = true;
                foreach (var prime in Primes)
                {
                    if (i % prime == 0) { 
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) { 
                    Primes.Add(i); 
                }
			}
            return Primes;
        }

        public static List<int> CalculatePrimeListUnderNthLength(int n)
        {
            List<int> Primes = new List<int>();
            int number = 5;

            Primes.Add(2);
            Primes.Add(3);

            while (number < n)
            {
                bool isPrime = true;

                foreach (var prime in Primes)
                {
                    if (number % prime == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Primes.Add(number);
                }
            }

            return Primes;
        }
    }
}
