using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10001;

            List<int> primes = PrimeCalculator(n);

            Console.WriteLine("{0}th prime is {1}.", n, primes.Max());
            Console.ReadLine();
        }

        public static List<int> PrimeCalculator(int numbToGen)
        {
            // populate initially with 2 and 3 
            List<int> primes = new List<int>(new int[] { 2, 3 });

            // Start n at 5, increment n by 2 every time, as prime cannot be even.
            for (int n = 5; primes.Count < numbToGen; n+=2)
            {
                bool isPrime = true;

                // for each item already in the prime list, 
                //check if the potential prime number is divisible by any of those.
                // if it is, then it cannot be prime.
                foreach (var item in primes)
                {
                    if (n % item == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                // if potential prime number is not divisible by any of the current primes, 
                //add it to the list as another prime.
                if (isPrime)
                    primes.Add(n);
            }

            return primes;
   
        }
        // finds if a number is prime or not.
        public static bool isPrime(int candidate)
        {
            for (int i = 2; i <= (candidate/2); i++)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
