using System;


namespace Assignment1
{
    internal class Subject
    {
        public static void Main()
        {
            int maths, phy, chem, total;
            Console.WriteLine("Enter your maths marks: ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your physics marks:");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your chem marks: ");
            chem = Convert.ToInt32(Console.ReadLine());

            if(maths >= 65)
            {
                Console.WriteLine("You are eligible");
            }
            else
            {
                Console.WriteLine("You are Not");
            }
            if (phy >= 55)
            {
                Console.WriteLine("You are eligible");
            }
            else
            {
                Console.WriteLine("You are Not");
            }
            if (chem >= 50)
            {
                Console.WriteLine("You are eligible");
            }
            else
            {
                Console.WriteLine("You are Not");
            }

            total = maths + phy + chem;

            if(total >= 180)
            {
                Console.WriteLine("You are eligible");
            }
            else
            {
                Console.WriteLine("You are Not");
            }

        }
    }
}
