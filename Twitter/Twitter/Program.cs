using System;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            Console.WriteLine("Please enter your message");
            entry = Console.ReadLine();

            if (entry.Length <= 140)
            {
                Console.WriteLine("the length of your message is acceptable");
            }
            else
            {
                Console.WriteLine("message to long " + entry.Length);
            }
        }
    }
}
