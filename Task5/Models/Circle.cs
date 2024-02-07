namespace Task5.Models
{
    public class Circle : Figure
    {
        public int Radius { get; private set; } = 0;

        public double Area { get; private set; } = 0;

        public double Perimeter { get; private set; } = 0;
        
        public Circle() 
        {
            var rnd = new Random();

            Radius = rnd.Next(1, 10);

            Area = CalculateArea();

            Perimeter = CalculatePerimeter();
        }

        private protected override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        private protected override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
