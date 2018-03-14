using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Ensures the integral unicode character is correctly displayed.

            // Variable assignments
            const byte sample1 = 0x3a;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            // Variable comparisons
            if(sample1.Equals(sample2))
            {
                Console.WriteLine("The samples are equal.");
            }

            if(heartRate > 40 && heartRate < 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }

            if(deposits > 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            } else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            float force = mass * acceleration;
            Console.WriteLine("force = {0}", force);

            Console.WriteLine("{0} is the disance.", distance);

            if(lost)
            {
                if(expensive) {
                    Console.WriteLine("I am really sorry! I will get the manager.");
                } else
                {
                    Console.WriteLine("Here is a coupon for 10% off");
                }
            }

            switch(choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            Console.WriteLine("{0} is an integral.", integral);

            for(int i=5; i<=10; i++)
            {
                Console.WriteLine("i={0}", i);
            }

            int age = 0;
            while(age < 6)
            {
                Console.WriteLine("age = {0}", age);
                age++;
            }

            Console.WriteLine("{0} {1}", greeting, name);

                Console.ReadKey(); // Prevent console window from auto closing.
        }
    }
}
