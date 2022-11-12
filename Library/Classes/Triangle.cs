using System;
using Library.Exceptions;
using Library.Interfaces;

namespace Library.Classes;

public class Triangle : IFigure
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }
    public bool IsRight => SideA * SideA == SideB * SideB + SideC * SideC
                           || SideB * SideB == SideA * SideA + SideC * SideC
                           || SideC * SideC == SideA * SideA + SideB * SideB; 

    public double S
    {
        get
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)); 
        }
    }

    /// <summary>
    /// Конструктор првильного  треугольника
    /// </summary>
    /// <param name="side">Сторона</param>
    public Triangle(double side) : this(side, side, side)
    {
    }
    /// <summary>
    /// Конструктор треугольника
    /// </summary>
    /// <param name="sideA">Длина стороны А</param>
    /// <param name="sideB">Длина стороны Б</param>
    /// <param name="sideC">Длина стороны С</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new InvalidFigureException("Сторона должна быть больше нуля!");
        if (sideA >= sideB + sideC
            || sideB >= sideA + sideC
            || sideC >= sideA + sideB)
            throw new InvalidFigureException("Треугольник с такими сторонами не существует!");
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
}