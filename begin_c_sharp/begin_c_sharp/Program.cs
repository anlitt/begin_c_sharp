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
            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            //for(int i = 0; i< 10; i++)
            //kleiner unterschied zwischen while und for
            Console.ReadLine();
        }
    }
}
