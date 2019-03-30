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
            //int i1 = 455;
            //int i2 = 84500;
            //decimal dec = 7.98845m;

            ////
            ////Приводим два числа типа int к типу short. 
            ////
            //Console.WriteLine((short)i1);
            //Console.WriteLine((short)i2);


            ////
            ////Приводим два числа типа int к типу short. 
            ////
            //Console.WriteLine((int)dec);
            //Console.ReadLine();

            string astr = Console.ReadLine();
            Double.TryParse(astr, out double a);
            string bstr = Console.ReadLine();
            Double.TryParse(bstr, out double b);
            string cstr = Console.ReadLine();
            Double.TryParse(cstr, out double c);

            Console.WriteLine($"Result {Program.SArifm(a,b,c)}");

        }

        public static double SArifm(double a, double b, double c)
            {
           
            return (double)(a+b+c)/3;
            }


    }
}
