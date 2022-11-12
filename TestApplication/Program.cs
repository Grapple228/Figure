using System;
using System.Collections.Generic;
using Library.Classes;
using Library.Interfaces;
using TestApplication.Classes;

namespace TestApplication
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var figures = new List<IFigure>
            {
                new Circle(3.56d),
                new Triangle(6),
                new Triangle(3, 4, 5),
                new Triangle(3, 4, 6),
                new Circle(223.5675),
                new Rectangle(4.5,35.32),
                new Rectangle(3),
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(
                    $"Площадь: {figure.S}" +
                    $"\n{(figure is Triangle triangle ? $"Прямоугольный: {triangle.IsRight}\n" : "")}"); 
            }

            Console.ReadKey();
        }
    }
}