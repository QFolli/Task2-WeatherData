using System;
using System.Collections.Generic;
using Task2.Subscriber;

namespace Task2.Publisher
{
    class WeatherData : IPublisher
    {
        private static List<ISubscriber> subscribers = new List<ISubscriber>();
        Random rand = new Random();

        public void AddSubscriber(ISubscriber sub)
        {
            subscribers.Add(sub);
        }

        public void DeleteSubscriber(ISubscriber sub)
        {
            if (subscribers.TrueForAll(s => s.Equals(sub)))
            {
                subscribers.Remove(sub);
            }
            else
            {
                Console.WriteLine("Данного подпищика нет в системе");
            }
        }

        public double GetTemperature()
        {
            double t = rand.Next(-20, 40);
            return t;
        }

        public double GetPressure()
        {
            double p = rand.Next(600, 800);
            return p;
        }

        public double GetHumidity()
        {
            double h = rand.Next(25, 70);
            return h;
        }

        public void NotifySub()
        {
            foreach (var item in subscribers)
            {
                item.GetNotify(GetTemperature(), GetPressure(), GetHumidity());
            }
        }
    }
}
