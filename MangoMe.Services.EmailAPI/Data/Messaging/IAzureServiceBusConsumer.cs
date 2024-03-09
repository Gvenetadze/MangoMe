namespace MangoMe.Services.EmailAPI.Data.Messaging
{
    public interface IAzureServiceBusConsumer
    {
        Task Start();
        Task Stop();
    }
}
