using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1
{
    public static class Task_2
    {
        public static void PerformConversion()
        {
            Console.WriteLine("Enter amount of money");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter currency");
            string currency = Console.ReadLine();
            Console.WriteLine(Task_2.Conversation(firstNumber, currency));
        }

        private static double Conversation(int firstNumber,string currency)
        {
            double result = 0;
            switch (currency)
            {
                case "rub":
                    result = Task_2.Rub(firstNumber);
                    break;
                case "dol":
                    result = Task_2.Dol(firstNumber);
                    break;
                case "euro":
                    result = Task_2.Euro(firstNumber);
                    break;
            }
            return result;
        }

        private static double Rub(int firstNumber)
        {
            return firstNumber * 0.42;
        }

        private static double Dol(int firstNumber)
        {
            return firstNumber * 27;
        }

        private static double Euro(int firstNumber)
        {
            return firstNumber * 31;
        }
    }
}
