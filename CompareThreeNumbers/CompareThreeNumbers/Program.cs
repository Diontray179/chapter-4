using System;

namespace CompareThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Num3;

            Console.WriteLine("Enter a integer >>> ");
            Num1 = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter a integer >>> ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a integer >>> ");
            Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 == Num2)
            {
                if (Num1 == Num3)
                {
                    Console.WriteLine("All Three numbers are equal");
                }
                else
                {
                    Console.WriteLine("Hey buddy only Num1 and Num2 are equal");
                }
              
            }
            else if (Num1 == Num2)
            {
                Console.WriteLine("First and Lat are equsal");
            }
            
            else if (Num2 == Num3)
              
            {
                Console.WriteLine("last two number are equal ");
            }
            else 
            {
                Console.WriteLine("No two NUmber are equal ");
            }
        }
    }
}
