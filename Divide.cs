using System;
namespace Assignment1
{
    internal class Divide
    {
        public static void Main3()
        {
            int num1, num2, divide;
            Console.Write("Enter 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            divide = num1 / num2;
            Console.Write("Result:" + divide);
        }
    }
}