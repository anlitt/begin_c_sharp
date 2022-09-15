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
            Console.WriteLine("Wie groß bist du ? (in Meter)?");
            float height = float.Parse(Console.ReadLine());
            int multiplicator = 3;
            Console.WriteLine("Du bist " + height * multiplicator + " groß");

            Console.ReadLine();
        }
    }
}
