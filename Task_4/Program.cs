using System;
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Написать программу расчета объема – V и площади поверхности – S цилиндра. 
// Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h
// Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 + 2πR2= 2πR(R + h)
// Результаты расчетов вывести на экран. 

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
        // Создание и инициализация константы и переменных.
        const double pi = 3.141592653;
        double cylinderRadius = 10, cylinderHeight = 13, cylinderVolume, cylinderSquare;
        
        // Расчета объема цилиндра.
        cylinderVolume = (pi * cylinderHeight * Math.Pow(cylinderRadius, 2));

        // Расчета площади поверхности цилиндра.
        cylinderSquare = (2 * pi * cylinderRadius * (cylinderRadius + cylinderHeight));

        // Вывод результатов вычислений на экран.
        Console.WriteLine($"Объем цилиндра V = {cylinderVolume}");
        Console.WriteLine($"Площадь поверхности цилиндра S = {cylinderSquare}");
        Console.ReadKey();

        }
    }
}
