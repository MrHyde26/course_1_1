using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_1_1.TaskMammal;

namespace course_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aquatic animal1 = new Aquatic(-10);
            Arial animal2 = new Arial(10);
            Mammal []animal = new Mammal[] { animal1, animal2 };

            foreach (var item in animal)
            {
                item.Eat(10);
            }
        } 
       
    }
}
