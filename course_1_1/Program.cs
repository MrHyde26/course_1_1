using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 455;
            int i2 = 84500;
            decimal dec = 7.98845m;

            //
            //Приводим два числа типа int к типу short. 
            //
            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);


            //
            //Приводим два числа типа int к типу short. 
            //
            Console.WriteLine((int)dec);
            Console.ReadLine();
        }

        static long Sum(long x, long y)
        {
            return x + y;
        }
    }
}
