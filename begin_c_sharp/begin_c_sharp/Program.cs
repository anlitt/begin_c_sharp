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
            string entry = "Das ist ein Text mit Wörtern";
            //0: Das 
            //1: ist 
            //2: ein
            //3: Text
            //4: mit
            //5: Wörtern
            string[] entries = entry.Split(' ');
            //wird immer bei Leertasten getrennt
            foreach (string wort in entries)
            {
                Console.WriteLine(wort);
            }
            for(int i = 0; i<entries.Length;i++)
                //sagt beides in diesem fall das selbe; hier reine präferenzfrage
            {
                Console.WriteLine(entries[i]);
            }
            Console.ReadLine();
        }
    }
}
