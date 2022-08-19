using System;
namespace Assignment1
{
    internal class MaxNum

    {
        public static void Main7()
        {
            int num1, num2, maxNum;
            Console.Write("Enter 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            Console.WriteLine("Maximum number is: " + maxNum);

        }
    }
}