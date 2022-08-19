using System;

namespace Assignment1
{
    internal class positiveNegative
    {
        public static void Main9()
        {
            int num;
          
            Console.Write("Input an number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {

                Console.WriteLine("is a positive number.\n", num);
            }
            else
            {
                Console.WriteLine("is a negative number. \n", num);
            }
        }
    }
}
