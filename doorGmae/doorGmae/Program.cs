using System;

namespace doorGmae
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 2); //creates a door between 1 and 3 
            int userEntry;
            string choice;
            Console.WriteLine("pick a door 1, 2, or 3 ");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == rndNumber)
            {
                Console.WriteLine("how did you know it was door {2}?", userEntry);
                Console.WriteLine("would you like to choice another door?");
                choice = Console.ReadLine();
                if (choice.Equals("yes")) ;
            }
            {
                Console.WriteLine("your lucky! but congrates you are the lucky");

            }
        }
    
    }
}
