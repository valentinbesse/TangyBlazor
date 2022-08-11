using Microsoft.AspNetCore.Components.Forms;
using TangyWeb_Server.Service.IService;

namespace TangyWeb_Server.Service
{
    public class FileUpload : IFileUpload
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public Task<bool> DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadFile(IBrowserFile file)
        {
            FileInfo fileInfo = new(file.Name);
            var fileName = Guid.NewGuid().ToString()+fileInfo.Extension;
            var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\images\\product";
        }
    }
}
