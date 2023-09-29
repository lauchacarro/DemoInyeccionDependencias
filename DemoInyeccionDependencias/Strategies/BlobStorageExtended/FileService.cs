namespace DemoInyeccionDependencias.Strategies.BlobStorageExtended
{
    public interface IFileExtendedService
    {
        Task UploadFile();
    }

    public class FileExtendedService : IFileExtendedService
    {
        // Al usar interfaz se vuelve más testeable

        private readonly IBlobServiceClientWrapper _blobServiceClient;

        public FileExtendedService(IBlobServiceClientWrapper blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public Task UploadFile()
        {
            return Task.CompletedTask;
        }
    }
}
