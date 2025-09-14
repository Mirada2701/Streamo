using MEGUTube.Application.Common.Models;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.Common.Interfaces
{
    public interface IVideoService
    {
        Task<(Result Result, string VideoFileId)> UploadVideoAsync(Stream source);
        Task<(Result Result, string VideoUrl)> GetUrlVideoAsync(string videoFileId);
        Task<Result> DeleteVideoAsync(string videoFileId);
        Task<bool> IsVideoExists(string videoFileId);
    }
}
