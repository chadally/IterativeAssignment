using System;

namespace IterativeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer that is between 2 and 10.");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 1)
            {
                for (int n = 0; n < i - 1; n++)
                    Console.WriteLine("You entered an odd number.");
            }
            else
            {
                for (int n = 0; n < i + 1; n++)
                    Console.WriteLine("You entered an even number.");
            }
        }
    }
}
