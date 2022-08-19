using System;

namespace Assignment1
{
    class Assignment
    {
        public static void Main1()
        {

            int num1, num2, sum;
            Console.Write("Enter 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.Write("Result:" + sum);
        }
    }
}