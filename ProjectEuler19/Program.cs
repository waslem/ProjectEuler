using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler19
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int year = 1900; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    // if first day of month is sunday
                    if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday)
                    {
                        counter++;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
