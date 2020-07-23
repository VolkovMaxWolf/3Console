using System;

namespace _3console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Задание 1");
                Console.Write("x1=");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("y1=");
                double y1 = double.Parse(Console.ReadLine());
                Console.Write("x2=");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("y2=");
                double y2 = double.Parse(Console.ReadLine());
                Console.Write("x3=");
                double x3 = double.Parse(Console.ReadLine());
                Console.Write("y3=");
                double y3 = double.Parse(Console.ReadLine());

                double line1 = f(x1,y1,x2,y2);
                double line2 = f(x2,y2,x3,y3);
                double line3 = f(x3,y3,x1,y1);

                double minLine = min(min(line1, line2), line3);
                if (minLine == line1)
                Console.WriteLine("Координаты точек расстаяние которых минимально : " +
                    "[ " + x1 + "; " + y1 + " ]" + ", " + "[ " + x2 + "; " + y2 + " ]");
                else if (minLine == line2) Console.WriteLine("Координаты точек расстаяние которых минимально : " +
                    "[ " + x2 + "; " + y2 + " ]" + ", " + "[ " + x3 + "; " + y3 + " ]");
                else Console.WriteLine("Координаты точек расстаяние которых минимально : " +
                    "[ " + x3 + "; " + y3 + " ]" + ", " + "[ " + x1 + "; " + y1 + " ]");

                Console.WriteLine("Задание 2");
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    Console.WriteLine("f({0:f2})={1:f4}", i, f(a, b, i));
                Console.WriteLine("Задание 3");
                double y;
                for (double i = a; i <= b; i += h)
                {
                    f(a, b, i, out y);
                    Console.WriteLine("f({0:f2})={1:f4}", i, y);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public static double min(double a, double b)
        {
            return (a <= b) ? a : b;
        }
        public static void f(double a, double b, double x, out double y)
        {
            if (x < 93) y = a + b * x;
            else if (x > 120) y = a * b * x;
            else y = b - a * x;
        }
        public static double f(double a, double b, double x)
        {
            if (x < 93) return a + b * x;
            else if (x > 120) return a * b * x;
            else return b - a * x;
        }
    }
}
