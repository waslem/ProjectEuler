using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, number = 1;
            Boolean found = false;

            while (!found)
            {
                
                int i = 20;

                // more efficient loop, quits if one of the modulus checks is false.
                while (i <= 20 && i > 0)
                {
                    if (number % i == 0)
                    {
                        counter++;
                        i--;
                    }
                    else
                        i = -1;
                }

                // can do this much more efficiently if we stop looping when our if statement is false.
                /*for (int i = 20; i > 0; i--)
                {
                    // check for 1->20 if numbers are evenly divisible
                    if (number % i == 0)
                    {
                        counter++;
                    }
                }*/

                // if 1-20 are all evenly divisible by the number, it is the answer.
                if (counter >= 20)
                {
                    found = true;
                    Console.WriteLine("Ans: {0}", number);
                }
                else
                {
                    counter = 0;
                    number++;
                }
            }
            Console.ReadLine();
        }
    }
}
