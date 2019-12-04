using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("please enter a number even or odd");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry % 2 == 0)
            {
                Console.WriteLine("the number " + userEntry + "is even");
            }
            else
            {
                Console.WriteLine("the number " + userEntry + "is odd");
            }

        }
    }
}
