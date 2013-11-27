using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjectEuler9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* pythagorean triplet
             * set of 3 numbers, a < b < c for which a^2 + b^2 = c^2
             * 
             * find where a + b + c = 1000
             * 
             * try find all pythagoean triplets; where a^2 + b^2 = c^2
             * of these, ans = if(a+b+c= 1000)
             */
            List<Triplet> tripletList = findAllTriplets();

            foreach (var triplet in tripletList)
            {
                double sum = (triplet.a + triplet.b + triplet.c);

                if (sum == 1000)
                {
                    Console.WriteLine("tripet found!, {0}+{1}+{2} = 1000", triplet.a, triplet.b, triplet.c);
                }
            }

            Console.ReadLine();
        }

        public static List<Triplet> findAllTriplets()
        {
            List<Triplet> tripletList = new List<Triplet>();

            for (int i = 0; i < 1000; i++)
            {
                tripletList.Add(new Triplet { a = 3 * i, b = 4 * i, c = 5 * i }); 
            }

            return tripletList;
        }
    }
}
