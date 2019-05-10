using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1.TaskMammal
{
    class Feeder
    {
        void Feed(Mammal[] mammals)
        {
            int foodAmount = 15;
            foreach (var item in mammals)
            {
                item.Eat(foodAmount);
                Console.WriteLine($"Animal eat other eat and him weight {item.Weight}");
            }
        }
    }
}
