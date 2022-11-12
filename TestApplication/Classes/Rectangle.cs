using Library.Exceptions;
using Library.Interfaces;

namespace TestApplication.Classes
{
    internal class Rectangle : IFigure
    {
        private double SideA { get; }
        private double SideB { get; }
        public double S => SideA * SideB;
    
        /// <summary>
        /// Конструктор квадрата
        /// </summary>
        /// <param name="side">Длина стороны</param>
        public Rectangle(double side) : this(side, side)
        {
        }
        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="sideA">Длина стороны А</param>
        /// <param name="sideB">Длина стороны Б</param>
        /// <exception cref="InvalidFigureException">Ошибка при создании фигуры</exception>
        public Rectangle(double sideA, double sideB)
        {
            if (sideA <= 0 || sideB <= 0)
                throw new InvalidFigureException("Сторона должна быть больше нуля!");
            SideA = sideA;
            SideB = sideB;
        }
    }
}