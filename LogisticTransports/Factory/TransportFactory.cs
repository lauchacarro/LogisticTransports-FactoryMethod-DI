using LogisticTransports.Enums;
using LogisticTransports.Transports;

namespace LogisticTransports.Factory
{
    public class TransportFactory : ITransportFactory
    {
        private readonly Dictionary<TransportType, Func<ITransport>> transports;

        public TransportFactory()
        {
            transports = new();
        }

        public ITransport CreateTransport(TransportType transportType)
        {
            Func<ITransport> funcion = transports[transportType];

            ITransport transport = funcion();

            return transport;
        }


        public void RegisterTransport(TransportType transportType, Func<ITransport> factoryMethod)
        {
            transports.Add(transportType, factoryMethod);
        }
    }
}
