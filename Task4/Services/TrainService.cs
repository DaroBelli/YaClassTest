using Task4.Models;
using Task4.Services.Interfaces;

namespace Task4.Controllers
{
    public class TrainService: ITrainService
    {
        private readonly Train[] trains = {
            new() { Destination = "Москва", Number = 5, DepartureTime = new TimeOnly(17, 0), },
            new() { Destination = "Анапа", Number = 1, DepartureTime = new TimeOnly(11, 30), }, 
            new() { Destination = "Анапа", Number = 3, DepartureTime = new TimeOnly(12, 30), },
            new() { Destination = "Саратов", Number = 8, DepartureTime = new TimeOnly(9, 0), }, 
            new() { Destination = "Мурманск", Number = 15, DepartureTime = new TimeOnly(22, 20), }, 
            new() { Destination = "Екатеринбург", Number = 4, DepartureTime = new TimeOnly(11, 0), },
        };

        public Train GetTrain(int number) 
        { 
            return trains.FirstOrDefault(t => t.Number == number);
        }

        public Train[] GetTrainsOrderByDestinationThenDepartureTime()
        {
            return [.. trains.OrderBy(x => x.Destination).ThenBy(x => x.DepartureTime)];
        }

        public Train[] GetTrainsFilterByActualTime()
        {
            TimeOnly timeNow = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss"));

            return trains.Where(x => x.DepartureTime > timeNow).ToArray();
        }
    }
}
