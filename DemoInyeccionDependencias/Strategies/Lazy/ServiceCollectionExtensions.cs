namespace DemoInyeccionDependencias.Strategies.Lazy
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddBotServiceLazier(this IServiceCollection services)
        {
            services.AddSingleton<BotServices>();

            return services;
        }
    }
}
