using Azure;
using Azure.Core;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace DemoInyeccionDependencias.Strategies.BlobStorageExtended
{

    public interface IBlobServiceClientWrapper
    {
        Pageable<BlobContainerItem> GetBlobContainers(
            BlobContainerTraits traits = BlobContainerTraits.None,
            BlobContainerStates states = BlobContainerStates.None,
            string prefix = default,
            CancellationToken cancellationToken = default);
    }

    public class BlobServiceClientWrapper : BlobServiceClient, IBlobServiceClientWrapper
    {
        public BlobServiceClientWrapper(Uri serviceUri, TokenCredential credential, BlobClientOptions options = default) : base(serviceUri, credential, options)
        {
        }
    }
}
