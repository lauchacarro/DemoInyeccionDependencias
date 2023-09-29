using Azure.Identity;
using Azure.Storage.Blobs;

using Microsoft.Extensions.Options;

namespace DemoInyeccionDependencias.Strategies.BlobStorage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlobStorage(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddOptions<BlobStorageOptions>()
                            .Bind(configuration.GetSection("BlobStorage"));



            services.AddScoped(sp =>
            {
                var options = sp.GetRequiredService<IOptions<BlobStorageOptions>>();

                var blobServiceClient = new BlobServiceClient(
                    new Uri(options.Value.Endpoint),
                    new DefaultAzureCredential());

                return blobServiceClient;

            });






            services.AddScoped<IFileService, FileService>();

            return services;
        }
    }
}
