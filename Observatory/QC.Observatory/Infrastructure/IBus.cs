namespace QC.Observatory.Infrastructure
{
    public interface IBus
    {
        void Publish(object message);
    }
}