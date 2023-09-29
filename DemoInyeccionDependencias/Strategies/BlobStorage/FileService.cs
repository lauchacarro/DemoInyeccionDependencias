using Azure.Storage.Blobs;

namespace DemoInyeccionDependencias.Strategies.BlobStorage
{
    public interface IFileService
    {
        Task UploadFile();
    }

    public class FileService : IFileService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public FileService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public Task UploadFile()
        {
            return Task.CompletedTask;
        }
    }
}
