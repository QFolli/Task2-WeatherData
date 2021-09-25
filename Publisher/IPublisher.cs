using Task2.Subscriber;

namespace Task2.Publisher
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber sub);
        void DeleteSubscriber(ISubscriber sub);
    }
}
