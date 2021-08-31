using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_to_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SampleCode();

            /*Here are some
            *Multiline
            *Comments
            */


            Console.ReadKey();

        }

        static void SampleCode()
        {
            Console.WriteLine("Give me your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.Write("How many hours of sleep did you get last night? ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("Good job. That's a lot of sleep.");
            }
            else if (hoursOfSleep > 6)
            {
                Console.WriteLine("Not bad, but you need more.");
            }
            else if (hoursOfSleep < 6)
            {
                Console.WriteLine("Dude you need more sleep.");
            }
            else
            {
                Console.WriteLine("I don't know what you wrote.");
            }
        }

    }
}
