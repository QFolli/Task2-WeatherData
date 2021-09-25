using Task2.Subscriber;
using Task2.Publisher;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentDisplay cureentDisplay = new CurrentDisplay(weatherData);
            StatisticDisplay statisticDisplay = new StatisticDisplay(weatherData);
            weatherData.NotifySub();
        }
    }
}
