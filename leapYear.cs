using System;


namespace Assignment1
{
    internal class leapYear
    {
        public static void Main11()
        {
            int year;
            
            Console.Write("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
            {
                Console.WriteLine(" is a leap year.\n", year);
            }
            else if ((year % 100) == 0)
            {
                Console.WriteLine(" is not a leap year.\n", year);
            }
            else if ((year % 4) == 0)
            {
                Console.WriteLine(" is a leap year.\n", year);
            }
            else
            {
                Console.WriteLine("is not a leap year.\n", year);
            }
        }
    }
    }

