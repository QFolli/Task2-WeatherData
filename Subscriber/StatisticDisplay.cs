using System;
using System.Collections.Generic;
using System.Linq;
using Task2.Publisher;

namespace Task2.Subscriber
{
    class StatisticDisplay : ISubscriber
    {
        public StatisticDisplay(IPublisher publisher)
        {
            publisher.AddSubscriber(this);
        }
        private static List<double> tempList = new List<double>() { -5, 10, 15, 21 };
        private static List<double> pressureList = new List<double>() { 610, 653 , 713, 780 };
        private static List<double> humidityList = new List<double>() { 32, 43, 25, 65 };

        public void GetNotify(double temp, double pressure, double humidity)
        {
            tempList.Add(temp);
            pressureList.Add(pressure);
            humidityList.Add(humidity);


            Console.WriteLine(":СРЕДНИЕ ЗНАЧЕНИЯ ЗА СЕГОДНЯ::");
            Console.WriteLine($"Средняя температура: {FindAverage(tempList)} град. Цельсия");
            Console.WriteLine($"Среднее давление: {FindAverage(pressureList)} мм.рт.ст.");
            Console.WriteLine($"Средняя влажность воздуха: {FindAverage(humidityList)} %");
        }

        private static double FindAverage(List<double> data)
        {
            return data.Average();
        }
    }
}
