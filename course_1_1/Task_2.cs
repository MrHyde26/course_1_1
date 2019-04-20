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
            var moneyString = Task_2.AskForMoney();
            decimal money = Task_2.ParseMoney(moneyString);
            Console.WriteLine("Enter currency");
            string currency = Console.ReadLine();
            Console.WriteLine(Task_2.Conversation(money, currency));
        }

        private static string AskForMoney()
        {
            Console.WriteLine("Enter amount of money");
            return Console.ReadLine();
        }


        private static decimal ParseMoney(string money)
        {
            if (decimal.TryParse(money, out decimal operand))
            {
                return operand;
            }
            else
            {
                throw new ArgumentException("The string cannot be parsed into double");
            }
        }

        private static decimal Conversation(decimal firstNumber,string currency)
        {
            double rate = 0;
            switch (currency)
            {
                case "rub":
                    rate = 0.48;
                    break;
                case "dol":
                    rate = 27;
                    break;
                case "euro":
                    rate = 31;
                    break;
            }

            return Task_2.CalculationRate(firstNumber, rate);
        }

        private static decimal CalculationRate(decimal firstNumber, double rate)
        {
            return firstNumber * (decimal)rate;
        }
    }
}
