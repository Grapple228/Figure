using System;
using Library.Exceptions;
using Library.Interfaces;

namespace Library.Classes;

public class Circle : IFigure
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    private double Radius { get; }
    public double S => Math.PI * Radius * Radius;
    
    /// <summary>
    ///  Конструктор круга
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new InvalidFigureException("Радиус фигуры должен быть больше нуля!");
        Radius = radius;
    }
}