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
            //Worker worker1 = new Worker("Иван", 25, 1000);
            //Worker worker2 = new Worker("Вася", 102, 2000);

            //Console.WriteLine($"Salary1 {worker1.Salary}");
            //Console.WriteLine($"Salary2 {worker2.Salary}");
            //Console.WriteLine($"Summ of salary = {worker1.Salary + worker2.Salary}");
            //Console.WriteLine($"Age1 {worker1.Age}");
            //Console.WriteLine($"Age2 {worker2.Age}");
            //Console.WriteLine($"Summ of age = {worker1.Age + worker2.Age}");

            //Worker2 worker1 = new Worker2("Иван", 25, 1000);
            //Worker2 worker2 = new Worker2("Вася", 102, 3000);
            //Console.WriteLine($"Salary1 {worker1.Salary}");
            //Console.WriteLine($"Salary2 {worker2.Salary}");
            //Console.WriteLine($"Summ of salary = {worker1.Salary + worker2.Salary}");


            //Student student1 = new Student("Иван", 25, 450, 3);
            //Student student2 = new Student("Вася", 30, 120, 1);
            //Console.WriteLine($"Student {student1.Name} age {student1.Age} grant {student1.Grant}.");

            //Driver driver = new Driver("Ivan", 33, 2500, 4,Category.B);
            //Console.WriteLine($"Student {driver.Name} age {driver.Age} salary {driver.Salary} category {driver.category} stag {driver.Year}.");

            Mammal animal1 = new Mammal(-10);
            Mammal animal2 = new Mammal(10);
            int foodAmount = 22;
            animal1.Eat(foodAmount);
            animal2.Eat(foodAmount);

        }

    }
}
