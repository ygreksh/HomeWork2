using System;

namespace ConsoleApp2
{
    class Program
    {
        //структура, описывающая правильный многоугольник
        public struct RegPol
        {
            public int Angles { get; set; }     // количество углов в многоугольнике
            public double Side { get; set; }    // длина стороны многоугольника
            public double Square { get; set; }  // площадь многоугольника
        }
        
        static void Main(string[] args)
        {
            //действия над классом
            Console.WriteLine("Классы");

            RegularPolygon polygon3 = new RegularPolygon { Angles = 3, Side = 1 };  //треугольник
            RegularPolygon polygon4 = new RegularPolygon { Angles = 4, Side = 1 };  //четырехугольник
            RegularPolygon polygon5 = new RegularPolygon { Angles = 5, Side = 1 };  //пятиугольник
            RegularPolygon polygon6 = new RegularPolygon { Angles = 6, Side = 1 };  //шестиугольник
                                 
            RegularPolygonSquare(polygon3);             
            polygon3.PrintSquare();                     //площадь не определена

            polygon3 = RegularPolygonSquare(polygon3);  
            polygon3.PrintSquare();                     //площадь определена

            RegularPolygonSquare(polygon4);
            polygon4.PrintSquare();                     //площадь не определена

            polygon4 = RegularPolygonSquare(polygon4);
            polygon4.PrintSquare();                     //площадь определена

            RegularPolygonSquare(ref polygon5);
            polygon5.PrintSquare();                     //площадь определена
            RegularPolygonSquare(ref polygon6);
            polygon6.PrintSquare();                     //площадь определена


            //действия над структурой
            Console.WriteLine("Структуры");

            RegPol regpol3 = new RegPol { Angles = 3, Side = 1 };  //треугольник
            RegPol regpol4 = new RegPol { Angles = 4, Side = 1 };  //четырехугольник
            RegPol regpol5 = new RegPol { Angles = 5, Side = 1 };  //пятиугольник
            RegPol regpol6 = new RegPol { Angles = 6, Side = 1 };  //шестиугольник

            RegPolSquare(regpol3);
            Console.WriteLine("Площадь " + regpol3.Angles + "-угольника равна " + regpol3.Square); //площадь не определена, равна 0
            RegPolSquare(ref regpol4);
            Console.WriteLine("Площадь " + regpol4.Angles + "-угольника равна " + regpol4.Square); //площадь определена
            regpol5 = RegPolSquare(regpol5);
            Console.WriteLine("Площадь " + regpol5.Angles + "-угольника равна " + regpol5.Square); //площадь определена
            regpol6 = RegPolSquare(regpol6);
            Console.WriteLine("Площадь " + regpol6.Angles + "-угольника равна " + regpol6.Square); //площадь определена

        }

        //Класс
        //вычисление площади правильного многоугольника, изменение самого передаваемого в параметры объекта
        public static void RegularPolygonSquare(ref RegularPolygon polygon)
        {
            double square = (polygon.Side * polygon.Side * polygon.Angles) / (4 * Math.Tan(Math.PI / polygon.Angles));
            polygon = new RegularPolygon { Side = polygon.Side, Angles = polygon.Angles, Square = square };
        }

        //Класс
        //вычисление площади правильного многоугольника, возврат нового объекта
        public static RegularPolygon RegularPolygonSquare(RegularPolygon polygon)
        {
            double square = (polygon.Side * polygon.Side * polygon.Angles) / (4 * Math.Tan(Math.PI / polygon.Angles));
            return new RegularPolygon { Side = polygon.Side, Angles = polygon.Angles, Square = square };
        }

        //Структура
        //вычисление площади правильного многоугольника, изменение самого передаваемого в параметры объекта
        public static void RegPolSquare(ref RegPol polygon)
        {
            double square = (polygon.Side * polygon.Side * polygon.Angles) / (4 * Math.Tan(Math.PI / polygon.Angles));
            polygon = new RegPol { Side = polygon.Side, Angles = polygon.Angles, Square = square };
        }

        //Структура
        //вычисление площади правильного многоугольника, возврат нового объекта
        public static RegPol RegPolSquare(RegPol polygon)
        {
            double square = (polygon.Side * polygon.Side * polygon.Angles) / (4 * Math.Tan(Math.PI / polygon.Angles));
            return new RegPol { Side = polygon.Side, Angles = polygon.Angles, Square = square };
        }

    }
}
