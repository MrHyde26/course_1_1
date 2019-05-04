using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }

    public class Figure2D
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Figure2D(int sideA, int sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public int CalculatorArea()
        {
            return SideA * SideB;
        }
    }

    public class Figure3D : Figure2D
    {
        public int SideC { get; set; }

        public Figure3D(int sideA, int sideB, int sideC) : base(sideA, sideB)
        {
            SideC = sideC;
        }


        public int Calculation3D()
        {
            //return SideA * SideB * SideC;
            return CalculatorArea() * SideC;
        }
    }
}

