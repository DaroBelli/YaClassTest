using Task4.Models;

namespace Task4.Services.Interfaces
{
    public interface ITrainService
    {
        public Train GetTrain(int number);

        public Train[] GetTrainsOrderByDestinationThenDepartureTime();

        public Train[] GetTrainsFilterByActualTime();
    }
}
