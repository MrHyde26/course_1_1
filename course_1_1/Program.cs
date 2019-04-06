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
            //
            //OddThreeDigit();
            //
            //
            //XYZ();
            //
            //
            Calculator();
            //
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
            if (threedigit % 2 == 0 && strthreedigit.Length == 3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void XYZ()
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * 2;
            Console.WriteLine(x);
        }

        public static void Calculator()
        {
            Console.WriteLine("Enter first number");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter arithmetic sign");
            string sign = (Console.ReadLine());
            int result;
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine($"Result {result}");
                break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine($"Result {result}");
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine($"Result {result}");
                    break;
                case "/":
                    if (operand2 != 0)
                    {

                        result = operand1 / operand2;
                        Console.WriteLine($"Result {result}");
                    }
                    else
                    {
                        Console.WriteLine( "Can't divided by zero");
                    }
                        break;

                default:
                    break;
            }
        }
    }
}
