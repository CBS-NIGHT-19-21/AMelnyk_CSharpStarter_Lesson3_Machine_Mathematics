using System;
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
// Используя формулу πR2, вычислите площадь круга и выведите результат на экран.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание и инициализация константы и переменных.
            const double pi = 3.141592653;
            double r = 5, areOfCircle;
            
            // Вычисление площади круга.
            areOfCircle = pi * Math.Pow(r, 2);

            // Вывод результатов вычислений на экран.
            Console.WriteLine($"Площадь круга = {areOfCircle}");
            Console.ReadKey();
        }
    }
}
