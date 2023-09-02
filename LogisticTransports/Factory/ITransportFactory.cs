using LogisticTransports.Enums;
using LogisticTransports.Transports;

namespace LogisticTransports.Factory
{
    public interface ITransportFactory
    {
        void RegisterTransport(TransportType transportType, Func<ITransport> factoryMethod);

        ITransport CreateTransport(TransportType transportType);
    }
}
