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

        /// <summary>
        /// Возвращает данные по фигуре.
        /// </summary>
        /// <returns></returns>
        public abstract string InfoFigure();
    }
}