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
            int.TryParse(astr, out int a);
            string bstr = Console.ReadLine();
            int.TryParse(astr, out int b);
            string cstr = Console.ReadLine();
            int.TryParse(astr, out int c);

            Console.WriteLine($"Result {Program.SArifm(a,b,c)}");

        }

        public static int SArifm(int a,int b,int c)
            {
            return (a*b*c)/3;
            }


    }
}
