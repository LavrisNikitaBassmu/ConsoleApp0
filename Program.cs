using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем длины двух катетов от пользователя
            Console.WriteLine("Введите длины двух катетов:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Вычисляем длину гипотенузы по теореме Пифагора
            double c = Math.Sqrt(a * a + b * b);

            // Вычисляем площадь и периметр треугольника
            double area = 0.5 * a * b;
            double perimeter = a + b + c;

            // Выводим результаты
            Console.WriteLine("Результаты:");
            Console.WriteLine($"Площадь: {area:F2}");
            Console.WriteLine($"Периметр: {perimeter:F2}");
        }
    }
}