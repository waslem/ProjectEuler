using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sumOfSquares = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i * i;
                sumOfSquares += i;
            }

            int ans = sumOfSquares * sumOfSquares;
            Console.WriteLine("Ans: {0}", ans - sum);
            Console.ReadLine();
        }
    }
}
