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
            int num1 = 55;
            int num2 = 153;

            Console.WriteLine($"{num1} + {num2} = {Program.Sum(num1,num2)}");
            Console.ReadLine();
        }

        static long Sum(long x, long y)
        {
            return x + y;
        }
    }
}
