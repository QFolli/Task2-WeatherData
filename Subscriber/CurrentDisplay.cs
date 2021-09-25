using System;
using Task2.Publisher;

namespace Task2.Subscriber
{
    public class CurrentDisplay : ISubscriber
    {
        public CurrentDisplay(IPublisher publisher)
        {
            publisher.AddSubscriber(this);
        }
        public void GetNotify(double t, double p, double h)
        {
            Console.WriteLine(":АКТУАЛЬНАЯ ИНФОРМАЦИЯ:");
            Console.WriteLine($"Температура: {t} град. Цельсия");
            Console.WriteLine($"Давление: {p} мм.рт.ст");
            Console.WriteLine($"Влажность воздуха: {h} %");
        }
    }
}
