using System;

namespace ageInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            string result = null;
            Console.WriteLine("Please enter your age so i can make fun of you");
            Console.WriteLine("if you call me a boomer you are going to die of old age");
            enterAge = Convert.ToInt32(Console.ReadLine());
            

            if (enterAge <= 12)
            {
                result = "you are just a young punk";
            }
            else if (enterAge > 12 && enterAge <= 17)
            {
                result = "your generation is the problem";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = "get a job loser, so you can paid some taxes hippie!";
            }
            //enter the other age group below this
            else if (enterAge > 26 && enterAge <= 35)
            {
                result = "your old";
            }
            else if (enterAge > 36 && enterAge <= 45)
            {
                result = "now your really getting old";
            }
            else if (enterAge > 45 && enterAge <= 54)
            {
                result = "really old";
            }
            else if (enterAge > 55 && enterAge <= 62)
            {
                result = "GOD YOUR OLD!";
            }
            else
            {
                result = "how do you not have an age";
            }

            //Do not type below the console.WriteLine
            Console.WriteLine(result);




        }
    }
}
