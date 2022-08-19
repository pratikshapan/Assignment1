using System;

namespace Assignment1
{
    internal class Triangle
    {
        public static void Main12()
        {
            int a, b, c, sum; 
            

            Console.Write("Input angle1 of triangle: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 2 of triangle: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 3 of triangle: ");
            c = Convert.ToInt32(Console.ReadLine());

           
            sum = a + b + c;

            
            if (sum == 180)
            {
                Console.Write("The triangle is valid.\n");
            }
            else
            {
                Console.Write("The triangle is not valid.\n");
            }
        }

    }
}

