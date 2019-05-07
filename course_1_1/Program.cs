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
            Worker worker2 = new Worker("Вася", 102, 2000);

            Console.WriteLine($"Salary1 {worker1.Salary}");
            Console.WriteLine($"Salary2 {worker2.Salary}");
            Console.WriteLine($"Summ of salary = {worker1.Salary + worker2.Salary}");
            Console.WriteLine($"Age1 {worker1.Age}");
            Console.WriteLine($"Age2 {worker2.Age}");
            Console.WriteLine($"Summ of age = {worker1.Age + worker2.Age}");

        }
       
    }
}
