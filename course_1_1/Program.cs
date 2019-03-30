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
