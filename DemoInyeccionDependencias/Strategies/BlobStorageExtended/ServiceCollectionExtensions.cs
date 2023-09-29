using Azure.Identity;

using DemoInyeccionDependencias.Strategies.BlobStorage;

using Microsoft.Extensions.Options;

namespace DemoInyeccionDependencias.Strategies.BlobStorageExtended
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlobStorageExtended(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IBlobServiceClientWrapper, BlobServiceClientWrapper>(sp =>
            {
                var options = sp.GetRequiredService<IOptions<BlobStorageOptions>>();

                var blobServiceClient = new BlobServiceClientWrapper(
                    new Uri(options.Value.Endpoint),
                    new DefaultAzureCredential());

                return blobServiceClient;

            });

            services.AddScoped<IFileExtendedService, FileExtendedService>();


            return services;
        }
    }
}
