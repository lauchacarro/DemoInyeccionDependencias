namespace DemoInyeccionDependencias.Strategies.Factory
{
    public interface ITransportFactory
    {
        void RegisterTransport(TransportType transportType, Func<ITransport> factoryMethod);

        ITransport CreateTransport(TransportType transportType);
    }
}
