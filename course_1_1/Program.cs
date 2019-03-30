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
            short num1 = 10;
            short num2 = 15;

            Console.WriteLine($"{num1} + {num2} = {Program.Sum(num1,num2)}");
            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
