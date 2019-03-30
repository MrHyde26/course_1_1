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
            int uberflu;
            int _Identifier;
            int \u006fldentifier;
            int myVar;
            int myVariab1e;

            double pi = 3.141592653;
            decimal e = 2.7182818284590452m;
            Console.WriteLine(pi);
            Console.WriteLine(e);

            string s1 = "\nмоя строка 1";
            string s2 = "\tмоя строка 2";
            string s3 = "\aмоя строка 3";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
          
            Console.WriteLine("Please enter a radius");
            string rstr = Console.ReadLine();
            int.TryParse(rstr, out int r);
            Console.WriteLine($"The square of the round {Program.PerformCalculation(r)}");
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;      
        }

       
    }
}
