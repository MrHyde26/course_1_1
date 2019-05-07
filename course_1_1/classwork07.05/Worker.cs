using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1.classwork07._05
{
    class Worker
    {
        public string Name { get; set; }
        private int age;
        public int Salary { get; set; }

        public Worker(string name, int age, int salary)
        {
            Name = name;
            Salary = salary;
            Age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0 && value < 101)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Incorrect Age " + Name);
                }
            }
        }
    }
}
