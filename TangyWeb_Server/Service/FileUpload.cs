using Microsoft.AspNetCore.Components.Forms;
using TangyWeb_Server.Service.IService;

namespace TangyWeb_Server.Service
{
    public class FileUpload : IFileUpload
    {
        


        public Task<bool> DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadFile(IBrowserFile file)
        {
            throw new NotImplementedException();
        }
    }
}
