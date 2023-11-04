using Application.Images;
using Microsoft.AspNetCore.Http;

namespace Application.Interfaces
{
    public interface IImageAccessor
    {
        Task<ImageUploadResult> AddImage(IFormFile file);
        Task<string> DeleteImage(string publicId);

    }
}
