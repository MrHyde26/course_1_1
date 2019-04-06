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
            //
            //HoursInDay();
            //
            //
            //ABetweenC();
            //
            OddThreeDigit();
        }

        public static void HoursInDay()
        {
            Console.WriteLine("Please enter a seconds");
            string strseconds = Console.ReadLine();
            int.TryParse(strseconds, out int seconds);
            int hours = seconds / 3600;
            Console.WriteLine($"Hours {hours}");
        }

        public static void ABetweenC()
        {
            Console.WriteLine("Enter A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b && b < c)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void OddThreeDigit()
        {
            string strthreedigit = Console.ReadLine();
            int threedigit = Convert.ToInt32(strthreedigit);
            if (threedigit%2==0 && strthreedigit.Length==3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
