using Task5.Models;
using Task5.Services.Interfaces;
using static Task5.Services.Interfaces.IFigureService;

namespace Task5.Services
{
    public class FigureService : IFigureService
    {
        /// <summary>
        /// Возвращает информацию по фигурам.
        /// </summary>
        /// <param name="count">Количество фигур.</param>
        /// <param name="figureType">Тип фигуры.</param>
        /// <returns></returns>
        public string[] InfoFiguries(int count, FigureType figureType)
        {
            if(figureType == FigureType.Rectangle)
            {
                return GetInfoStrings<Rectangle>(count);
            }
            else if (figureType == FigureType.Circle)
            {
                return GetInfoStrings<Circle>(count);
            }
            else 
            { 
                return GetInfoStrings<Triangle>(count);
            }
        }

        /// <summary>
        /// Формирует массив строк с информацией по фигурам.
        /// </summary>
        /// <typeparam name="T">Фигура.</typeparam>
        /// <param name="count">Количество фигур.</param>
        /// <returns></returns>
        private static string[] GetInfoStrings<T>(int count) where T : Figure, new()
        {
            string[] infoFiguries = new string[count];

            for (int i = 0; i < count; i++)
            {
                Figure figure = new T();
                infoFiguries[i] = figure.InfoFigure();
            }

            return infoFiguries;
        }
    }
}
