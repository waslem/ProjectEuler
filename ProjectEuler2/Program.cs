using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* fibonacci sequence...
             * calculated by adding the previous two terms, starting with 1 and 2.
             * algorithm to calc fibonacci, 
             * ans-1 + ans-2 = ans
             * function fib, 
             *              if n==0; return 0,
             *              if n== 1 return 1;
             *              else
             *                  return fib(n-1)+fib(n-2)
            */

            List<int> answerList = new List<int>();
            int answer = 0, i = 0;

            do
            {
                answer = fibbonacci(i);
                i++;
                if (answer < 4000000) { answerList.Add(answer); }

            } while (answer < 4000000);

            int ans = sumEvens(answerList);

            Console.WriteLine("Sum of even fibonacci numbers < 4Mill : {0}", ans);
            Console.ReadLine();
        }

        // fibbonacci recursive method.
        public static int fibbonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (fibbonacci(n - 1) + fibbonacci(n - 2));
            }
        }

        public static int sumEvens(List<int> fibList)
        {
            int count = 0;

            foreach (int item in fibList)
            {
                // if even...
                if (item % 2 == 0)
                    count += item;
            }
            return count;
        }
    }
}
