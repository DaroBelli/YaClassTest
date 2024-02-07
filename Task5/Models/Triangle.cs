namespace Task5.Models
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Массив сторон.
        /// </summary>
        private readonly int[] sides;

        /// <summary>
        /// Массив сторон без самой большой стороны.
        /// </summary>
        private int[] sidesNotMax = new int[2];

        private bool IsRight { get; set; }

        public int A { get; private set; } = 0;

        public int B { get; private set; } = 0;

        public int C { get; private set; } = 0;

        public double Area { get; private set; } = 0;

        public double Perimeter { get; private set; } = 0;

        public Triangle()
        {

            var rnd = new Random();

            A = rnd.Next(1, 10);

            B = rnd.Next(1, 10);

            C = rnd.Next(Math.Abs(B - A + 1), 10);

            sides = [A, B, C];

            Perimeter = CalculatePerimeter();

            IsRight = IsRightTriangle();

            Area = CalculateArea();
        }

        private protected override double CalculateArea()
        {
            if (IsRight)
            {
                //Площадь по двум катетам.
                return sidesNotMax[0] * sidesNotMax[1] / 2; 
            }

            var halfPerimetr = Perimeter / 2;

            //Формула Герона.
            return Math.Sqrt(halfPerimetr * (halfPerimetr - sides[0]) * (halfPerimetr - sides[1]) * (halfPerimetr - sides[2]));
        }

        /// <summary>
        /// Провереряем, является ли треугольник прямоугольным.
        /// </summary>
        private bool IsRightTriangle()
        {
            var maxSide = sides.Max();

            sidesNotMax = sides.Where(x => x != maxSide).ToArray();

            //Поиск гипотенузы (самой длинной стороны) по формуле Пифагора.
            var pifagor = Math.Sqrt(sidesNotMax[0] * sidesNotMax[0] + sidesNotMax[1] * sidesNotMax[1]);

            return pifagor == maxSide;
        }

        private protected override double CalculatePerimeter()
        {
            return sides.Sum();
        }
    }
}
