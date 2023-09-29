using DemoInyeccionDependencias.Strategies.Reflection;

namespace DemoInyeccionDependencias.Strategies.Lazy
{
    public class BotServices
    {
        private readonly IServiceProvider _serviceProvider;
        public BotServices(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            ProductService = new(serviceProvider);
            StockService = new(serviceProvider);
        }

        public Lazier<IProductService> ProductService { get; }
        public Lazier<IStockService> StockService { get; }
        public IStockService StockService2 { get { return _serviceProvider.GetRequiredService<IStockService>(); } }

    }
}



