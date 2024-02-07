using Task5.Models;

namespace Task5.Services.Interfaces
{
    public interface IFigureService
    {
        string[] InfoFiguries(int count, FigureType figureType);

        enum FigureType
        {
            Rectangle,
            Triangle,
            Circle
        }
    }
}
