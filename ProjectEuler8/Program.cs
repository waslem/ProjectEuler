using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* loop through a number 5 digits at a time
             * Store the current 5 digit number and compare to largest
             * if new largest, make largest
             */

            const string oneThousandDigitNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            
            string largestNum = largestConsecutiveFiveDigits(oneThousandDigitNumber);
            int largestProduct = largestConsecutiveFiveProduct(oneThousandDigitNumber);

            Console.WriteLine("largest consecutive number is {0}", largestNum);
            Console.WriteLine("Largest consecutive product of 5 numbers: {0}", largestProduct);

            Console.ReadLine();
        }

        private static int largestConsecutiveFiveProduct(string oneThousandDigitNumber)
        {
            int largestNum = 0;

            // assumes 1000 digit number string has only valid numbers.
            // compare every consecutive 5 numbers starting from i=0 to i=100digitnumber.length-4
            for (int i = 0; i < oneThousandDigitNumber.Length - 4; i++)
            {
                // have to take string[i].toString() and parse as int.
                int num = Int32.Parse(oneThousandDigitNumber[i].ToString()) *
                            Int32.Parse(oneThousandDigitNumber[i+1].ToString()) *
                            Int32.Parse(oneThousandDigitNumber[i+2].ToString()) *
                            Int32.Parse(oneThousandDigitNumber[i+3].ToString()) *
                            Int32.Parse(oneThousandDigitNumber[i+4].ToString());

                if (num > largestNum)
                {
                    largestNum = num;
                }
                num = 0;
            }
            return largestNum;
        }
        private static string largestConsecutiveFiveDigits(string oneThousandDigitNumber)
        {
            string largestNum = "0";

            for (int i = 0; i < oneThousandDigitNumber.Length - 4; i++)
            {
                string num = oneThousandDigitNumber[i].ToString() +
                                oneThousandDigitNumber[i + 1].ToString() +
                                oneThousandDigitNumber[i + 2].ToString() +
                                oneThousandDigitNumber[i + 3].ToString() +
                                oneThousandDigitNumber[i + 4].ToString();

                if (Int32.Parse(num) > Int32.Parse(largestNum))
                {
                    largestNum = num;
                }

            }
            return largestNum;
        }
    }
}
