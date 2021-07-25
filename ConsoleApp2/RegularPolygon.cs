using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    //Класс правильный многоугольник
    class RegularPolygon
    {
        public int Angles { get; set; } // количество углов в многоугольнике

        public double Side;             // длина стороны многоугольника

        public double Square { get; set; } // площадь многоугольника
        
        public void PrintSquare()
        {
            if (this.Square != 0)
                Console.WriteLine("Площадь данного " + Angles + "-угольника со стороной " + Side + " равна " + Square);
            else Console.WriteLine("Площадь данного " + Angles + "-угольника со стороной " + Side + " не определена");
        }
    }
}
