using Microsoft.Extensions.DependencyInjection;

namespace LogisticTransports.DependencyInjection
{
    public class TransportFactoryBuilder : ITransportFactoryBuilder
    {
        public TransportFactoryBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
