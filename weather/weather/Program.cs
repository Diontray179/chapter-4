using System;

namespace weather
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp8am;
            int temp12pm;
            int temp5pm;
            int temp8amtoCelsius;
            int temp12pmtoCelsius;
            int temp5pmtoCelsius;
            Console.WriteLine("please enter a temp at 8 AM");
            temp8am = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter a temp at 8 AM");
            temp12pm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter a temp at 8 AM");
            temp5pm = Convert.ToInt32(Console.ReadLine());


            if (temp8am <= 32 || temp12pm <=32 || temp5pm <=32 )
            {
                Console.WriteLine("it is freezing");
            }
            else if (temp8am >= 100 || temp12pm>= 100 || temp5pm >= 100)
            {
                Console.WriteLine("it is Hot");
            }

            temp8amtoCelsius = (temp8am - 32) / (5 / 9);
            temp12pmtoCelsius = (temp12pm - 32) / (5 / 9);
            temp5pmtoCelsius = (temp5pm - 32) / (5 / 9);
            Console.WriteLine("8:00 am - " + temp8amtoCelsius);
            Console.WriteLine("12:00 pm - " + temp12pmtoCelsius);
            Console.WriteLine("5:00 pm - " + temp5pmtoCelsius);
        }
    }
}
