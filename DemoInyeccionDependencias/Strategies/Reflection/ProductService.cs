namespace DemoInyeccionDependencias.Strategies.Reflection;


public interface IProductService : ITranscientService
{

}

public class ProductService : IProductService
{
}



public interface IStockService : ITranscientService
{
    int GetStock();
}

public class StockService : IStockService
{
    public StockService()
    {
    }

    public int GetStock()
    {
        return 1;
    }
}
