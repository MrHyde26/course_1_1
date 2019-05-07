using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_1_1.classwork07._05;

namespace course_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Иван", 25, 1000);
            Worker worker2 = new Worker("Вася", 26, 2000);

            Console.WriteLine($"Summ of salary = {worker1.Salary + worker2.Salary}");

        }
       
    }
}
