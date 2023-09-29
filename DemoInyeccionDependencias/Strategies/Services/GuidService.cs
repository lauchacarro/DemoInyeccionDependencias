namespace DemoInyeccionDependencias.Strategies.Services
{
    public class GuidService
    {
        public GuidService()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
