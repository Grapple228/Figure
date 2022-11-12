using System;

namespace Library.Exceptions;

public class InvalidFigureException : Exception
{
    /// <summary>
    /// Ошибка при создании фигуры
    /// </summary>
    /// <param name="message">Сообщение ошибки</param>
    public InvalidFigureException(string message) : base(message)
    { }  
}