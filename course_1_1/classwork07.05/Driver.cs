using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1.classwork07._05
{
    class Driver : Worker2
    {
        public int Year { get; set; }
        public Category category;

        public Driver(string name, int age, int salary, int year, Category category) : base(name, age, salary)
        {
            Year = year;
        }
      
    }
    enum Category
    {
        A,
        B,
        C
    }
}
