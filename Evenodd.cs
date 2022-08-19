using System;


namespace Assignment1
{
    internal class Evenodd
    {
        public static void Main8()
        {
            int num1, rem1;
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("is an even integer.\n", num1);
            else
                Console.WriteLine("is an odd integer.\n", num1);
        }
    }
 }

