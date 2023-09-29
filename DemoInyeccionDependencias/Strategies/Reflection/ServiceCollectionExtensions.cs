namespace DemoInyeccionDependencias.Strategies.Reflection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServicesRefactor(
            this IServiceCollection services)

        {
            services.AddWithReflection<ITranscientService>(ServiceDescriptor.Transient);
            services.AddWithReflection<IScopedService>(ServiceDescriptor.Scoped);
            services.AddWithReflection<ISingletonService>(ServiceDescriptor.Singleton);

            return services;
        }


        public static IEnumerable<Type> GetTypes(Type interfaceType)
        {
            var implementingTypes = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                    .Where(type => interfaceType.IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

            return implementingTypes;
        }


        public static void AddWithReflection<T>(this IServiceCollection services, Func<Type, Type, ServiceDescriptor> func)
        {

            var interfaceType = typeof(T);

            var implementingTypes = GetTypes(interfaceType);

            foreach (var implementingType in implementingTypes)
            {
                foreach (var implementedInterface in implementingType.GetInterfaces())
                {
                    if (implementedInterface != interfaceType)
                    {
                        services.Add(func(implementedInterface, implementingType));
                    }
                }
            }
        }
    }
}
