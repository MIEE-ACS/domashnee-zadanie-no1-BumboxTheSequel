using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1_Makogon_UTS21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек A(x1,y1),B(x2,y2),C(x3,y3):");
            Console.Write("ввод координат точки A(x1,y1):\n x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("ввод координат точки B(x2,y2):\n x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("ввод координат точки C(x3,y3):\n x3 = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = double.Parse(Console.ReadLine());
            if ((x3 - x1) / (x2 - x1) == (y3 - y1) / (y2 - y1)) //проверка точки A(x3,y3) на выполнение равенства при подставке
                                                                //её координат в уравнение прямой, проходящей через точки A(x1,y1) и В(x2,y2)
            {
                Console.WriteLine("введены координаты, приводящие к расположению точек на одной прямой. Перезапустите программу и повторите снова.");
            }
            else
            {
                double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //расчёт расстояний между точками по формуле
                double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                double c = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double p = (a + b + c) / 2; // половина периметра
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // расчёт площади треугольника по формуле
                Console.WriteLine($"площадь S треугольника с вершинами в точках A, B и C равна:\n {S:0.00}");
            }
        }
    }
}
