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
            int i = 0; 
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            //for(int i = 0; i< 10; i++)
            //kleiner unterschied zwischen while und for
            //do ist fußgesteuert, er macht es auf jeden fall und while ist kopfgesteuert, das heißt es wird zuerst geprüft ob es gemacht werden kann
            Console.ReadLine();
        }
    }
}
