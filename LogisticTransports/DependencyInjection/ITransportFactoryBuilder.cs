using Microsoft.Extensions.DependencyInjection;

namespace LogisticTransports.DependencyInjection
{
    public interface ITransportFactoryBuilder
    {
        IServiceCollection Services { get; }
    }
}
