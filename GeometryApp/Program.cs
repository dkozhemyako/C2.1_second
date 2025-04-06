using System;
using GeometryLibrary;

namespace GeometryLibrary {

    internal class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть координати початку відрізка:");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВведіть координати кінця відрізка:");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            
            Segment segment = new Segment(x1, y1, x2, y2);

            Console.WriteLine("\nКоординати відрізка:");
            Console.WriteLine($"Початок: ({segment.X1}, {segment.Y1})");
            Console.WriteLine($"Кінець:  ({segment.X2}, {segment.Y2})");

            double length = segment.GetLength();
            Console.WriteLine($"Довжина відрізка: {length}");

            double angle = segment.GetAngleDegrees();
            Console.WriteLine($"Кут з віссю OX: {angle}°");

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }

    }
}
