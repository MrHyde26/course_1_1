using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1.classwork07._05
{
    class Worker2 : User
    {
        private int salary;

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Incorrect Salary ");
                }
            }
        }
        public Worker2(string name, int age, int salary) : base(name,age)
        {
            Salary = salary;
            
        }
    }
}
