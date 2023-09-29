﻿namespace DemoInyeccionDependencias.Strategies.Bulder
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
