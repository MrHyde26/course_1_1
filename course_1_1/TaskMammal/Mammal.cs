using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1.TaskMammal
{
    class Mammal
    {
        private int age;
        private int weight = 10;

        public Mammal(int age)
        {
            Age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                weight = value;
            }

        }

        public void Eat(int foodAmount)
        {

            if (foodAmount > 5)
            {
                weight += (foodAmount / 5);
            }
            if (age < 1)
            {
                Console.WriteLine($"Animal eat milk and him weight {weight}");
            }
            else
            {
                Console.WriteLine($"Animal eat other eat and him weight {weight}");
            }
        }
    }
}
