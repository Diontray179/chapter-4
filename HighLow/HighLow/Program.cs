using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10);  // creates a number between 1 and 10
            int userEntry;
            string Choice;
            Console.WriteLine("Plases enter a number 1 and 10");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == rndNumber) 
            {
                Console.WriteLine("how did you know the number");
                Console.WriteLine("Would you like to go for double or nothing? ");
                Choice = Console.ReadLine();
                if (Choice.Equals("yes")) ;
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("congrats you are an gambler");

            else 
            {
                Console.WriteLine("{0} that was incorrect.  ", userEntry);
            }
        }
    }
}
