using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler4
{
    class Program
    {
        static void Main(string[] args)
        {
            // check each product of 3 digit numbers
            // find length if digits in product, divide product into 2 sections,
            // if first matches second, it is a palindrome .
            // find the largest palidrome.

            int sum = 0;
            int largest = 0;
            int proda = 0, prodb = 0;
            int productsToCalculate = 1000;
            for (int i = 0; i < productsToCalculate; i++)
            {
                for (int j = 0; j < productsToCalculate; j++)
                {
                    sum = j * i;
                    Boolean isPalendrome = CheckPalendrome(sum);
                    if (largest <= sum && isPalendrome == true)
                    {
                        proda = i;
                        prodb = j;
                        largest = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine("largest palendrome = {0}, sum of {1} and {2}", largest, proda, prodb);
            Console.ReadLine();
        }

        // method that reverses the characters in a string and returns it.
        private static string ReverseString(string right)
        {
            // create an array of chars from string
            char[] rightArray = right.ToArray();

            // use Array method to reverse the char array
            Array.Reverse(rightArray);

            return new string(rightArray);
        }

        private static Boolean CheckPalendrome(int num)
        {
            string strSum = num.ToString();
            int middlePos = 0;
            string left = null;
            string right = null;

            // if str length is even
            if (strSum.Length % 2 == 0)
            {
                middlePos = strSum.Length / 2;
                left = strSum.Substring(0, middlePos);
                right = strSum.Substring(middlePos);
            }
            // for now return false if string length is odd.
            else
                return false;

            // reverse the right side.
            string rightReverse = ReverseString(right);

            if (left == rightReverse)
            {
                Console.WriteLine("{0} is a palindrome.", strSum);
                return true;
            }
            else 
                return false;
        }
    }
}
