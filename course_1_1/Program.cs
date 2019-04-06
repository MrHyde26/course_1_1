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

            Console.WriteLine("Please enter a seconds");
            string strseconds = Console.ReadLine();
            int.TryParse(strseconds, out int seconds);
            Console.WriteLine($"Hours {Program.HoursInDay(seconds)}");
        }

        public static int HoursInDay(int seconds)
        {
            int hours = seconds / 3600;
            return hours;
        }
    }
}
