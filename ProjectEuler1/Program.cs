using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* first task
             * for each number 1 -> 1000, if it is a multiple of 3 or 5, add it too the list.
             * finally, sum the list of multiples togeather.
            */
            const int count = 1000;

            List<int> multiple = new List<int>();

            for (int i = 0; i < count; i++)
			{
                if (i % 3 == 0) {
                    multiple.Add(i);
                }
                else if (i % 5 == 0){
                    multiple.Add(i);
                }
			}

            int sum = 0;

            foreach (int item in multiple)
            {
                sum += item;
            }

            Console.WriteLine("Sum of multiples of 3 or 5 below {0} = {1}", count, sum);

            Console.ReadLine();
        }
    }
}
