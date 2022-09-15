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
            Console.WriteLine("wie heißt du?");
            string userName = Console.ReadLine();
        
            Console.WriteLine("hello " + userName);
            Console.WriteLine("wie alt bist du aktuell?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie alt bist du in X Jahren?");
            int nextYear = Convert.ToInt32(Console.ReadLine());
            int sumYear = age + nextYear;
            Console.WriteLine("Du bist also in " + nextYear + " Jahren, " + sumYear);
            Console.ReadLine();
        }
    }
}
