using System;


namespace Assignment1
{
    internal class Teenage
    {
        public static void Main6()
        {
            int age;
            Console.Write("Input the age  : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.Write("Your are Teenager.\n");
            }
            else
                Console.Write("Your are Not Teenager.\n");
            Console.WriteLine();

        }
    }
}