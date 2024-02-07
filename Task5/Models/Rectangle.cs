namespace Task5.Models
{
    public class Rectangle : Figure
    {
        public int A { get; private set; } = 0;

        public int B { get; private set; } = 0;

        public double Area { get; private set; } = 0;

        public double Perimeter { get; private set; } = 0;

        private readonly bool isSquare = false;  

        public Rectangle() 
        {
            var rnd = new Random();

            A = rnd.Next(1, 10);

            B = rnd.Next(1, 10);

            isSquare = A == B;

            Perimeter = CalculatePerimeter();

            Area = CalculateArea();
        }

        private protected override double CalculateArea()
        {
            if (isSquare)
            {
                return A * A;
            }

            return A * B;
        }

        private protected override double CalculatePerimeter()
        {
            if (isSquare)
            {
                return A * 4;
            }

            return (A + B) * 2;
        }
    }
}
