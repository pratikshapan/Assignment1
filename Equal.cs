using System;


namespace Assignment1
{
    internal class Equal
    {
        public static void Main5()
        {
            int v1, v2;
            Console.Write("Input 1st number: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            if (v1 == v2)
            {
                Console.WriteLine("are equal.\n", v1, v2);
            }
            else
            {
                Console.WriteLine("are not equal.\n", v1, v2);
            }
        }
    }
}