using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1.classwork07._05
{
    class Student : User
    {
        public int Grant { get; set; }
        public int Course { get; set; }


        public Student(string name, int age, int grant, int course) : base(name, age)
        {
            Grant = grant;
            Course = course;
        }
    }
}
