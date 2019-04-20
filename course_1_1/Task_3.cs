using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1
{
    public static class Task_3
    {
        public static void PerfomCredit()
        {
            decimal credit = 10000;
            Console.WriteLine("Enter deposite");
            decimal deposite = Convert.ToDecimal (Console.ReadLine());
            Console.WriteLine(LoanPayment(credit, deposite));
        }

        private static decimal LoanPayment(decimal credit, decimal deposite)
        {
            decimal result = 0;

            if (credit > deposite)
            {
                result = Count(credit, deposite);
            }
            else if (credit < deposite)
            {
                result = Math.Abs(Count(credit, deposite));
            }
            else
            {
                throw new ArgumentException("Loan repaid");
            }
            return result;
        }

        private static decimal Count(decimal credit, decimal deposite)
        {
            return credit - deposite;
        }
    }
}
