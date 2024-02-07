namespace Task4.Models
{
    public struct Train
    {
        public string Destination { get; set; }

        public int Number { get; set; }

        public TimeOnly DepartureTime { get; set; }
    }
}
