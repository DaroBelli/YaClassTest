namespace Task5.Models
{
    /// <summary>
    /// Абстрактный класс фигура.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns></returns>
        private protected abstract double CalculateArea();

        /// <summary>
        /// Вычисляет периметр фигуры.
        /// </summary>
        /// <returns></returns>
        private protected abstract double CalculatePerimeter();
    }
}