using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begin_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Du kommscht hier net rein!");
            }
            else
            {
                if (age < 28)
                { Console.WriteLine("Einmal den Ausweis bitte!"); 
                }
                else
                { Console.WriteLine("Bei dir sehe ich, dass du alt genug bist.");
                }
                Console.WriteLine("Viel Spaß heute abend");
            }
            Console.ReadLine();
        }
    }
}
