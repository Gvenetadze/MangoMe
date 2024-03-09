using MangoMe.Services.EmailAPI.Data.Messaging;
using System.Reflection.Metadata;

namespace MangoMe.Services.EmailAPI.Extension
{
    public static class ApplicationBuilderExtensions
    {
        private static IAzureServiceBusConsumer ServiceBusConsumer { get; set; }
        public static IApplicationBuilder UseAzureServiceBusConsumer(this IApplicationBuilder app)
        {
            ServiceBusConsumer = app.ApplicationServices.GetService<IAzureServiceBusConsumer>();
            var hostAplicationLife = app.ApplicationServices.GetService<IHostApplicationLifetime>();

            hostAplicationLife.ApplicationStarted.Register(OnStart);
            hostAplicationLife.ApplicationStopping.Register(OnStop);

            return app;
        }

        private static void OnStop()
        {
            ServiceBusConsumer.Stop();
        }

        private static void OnStart()
        {
            ServiceBusConsumer.Start();
        }
    }
}
