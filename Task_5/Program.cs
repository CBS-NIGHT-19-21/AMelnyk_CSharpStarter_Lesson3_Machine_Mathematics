using System;
// Используя Visual Studio, создать проект по шаблону Console Application. 
// Проверите, можно ли создать переменные со следующими именами: 
// uberflu ?, _Identifier, \u006fIdentifier, &myVar, myVariab1le

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
           // Создание и инициализация переменных.
           // int uberfly?= 10;
            int _Identifier = 255;
            int \u006fidenntifier = 123;
           // int &myVar = 123;
            int myVariab1le = 123;


           // Console.WriteLine(uberfly?);
            Console.WriteLine(_Identifier);
            Console.WriteLine(\u006fidenntifier);
           // Console.WriteLine(&myVar);
            Console.WriteLine(myVariab1le);
        }
    }
}
