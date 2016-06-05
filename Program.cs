using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practisingrandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int myint;
            double mydouble;
            Random myrandom = new Random();
            mydouble = myrandom.NextDouble();
            myint = (int)mydouble;
            Console.WriteLine(myint);
            Console.ReadLine();

            double raw;
            double big;
            double bigger;
            int die;
            raw = myrandom.NextDouble();
            Console.WriteLine("raw: {0}", raw);
            big = raw * 6;
            Console.WriteLine("big: {0}", big);
            bigger = big + 1;
            Console.WriteLine("bigger: {0}", bigger);
            die = (int)bigger;
            Console.WriteLine("die: {0}", die);

            die = (int)(myrandom.NextDouble() * 6) + 1;
            Console.WriteLine("another die: {0}", die);

            Console.WriteLine();
            Console.WriteLine();

            // my own tryout
            int die2;
            die2 = (int)(myrandom.NextDouble() * 6) + 1;
            Console.WriteLine("2nd Die: {0}", die2);
            Console.ReadLine();
            Console.WriteLine("press any key to quit");
            Console.ReadLine();
        }
    }
}
