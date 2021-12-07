using System;
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создайте две целочисленные переменные и выведите на экран результаты всех арифметических 
// операций над этими двумя переменными.

namespace Additaonal_task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных.
            int operand1 = 11, operand2 = 17;
            {
                // Сложение двух целочисленных переменных.
                int total = operand1 + operand2;
                Console.WriteLine($"Cумма двух переменных = {total}");
            }
            {
                // Вычитание двух целочисленных переменных.
                int difference = operand1 - operand2;
                Console.WriteLine($"Разница двух переменных = {difference}");
            }
            {
                // Умножение двух целочисленных переменных.
                int product = operand1 * operand2;
                Console.WriteLine($"Произведение двух переменных = {product}");
            }
            {
                // Деление двух целочисленных переменных.
                // При делении возникает две проблемы:
                // 1. Необходимость организации проверки деления на ноль;
                // 2. Для получения более точного результата необходимо использовать типы данных с плавающей точкой. 
                decimal division = (operand1 / operand2);
                Console.WriteLine($"Деление двух переменных = {division}");
            }
            {
                // Остатча от деления двух целочисленных переменных.
                int divisionOst = operand1 % operand2;
                Console.WriteLine($"Остаток от деления двух переменных с остачей = {divisionOst}");
            }

            Console.ReadKey();
        }
    }
}
