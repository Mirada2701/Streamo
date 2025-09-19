using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.Common.Interfaces
{
    public interface IVideoService
    {
        Task<(Result Result, string VideoFileId)> UploadVideoAsync(Stream source);
        Task<(Result Result, string VideoUrl)> GetUrlVideoAsync(string videoFileId);
        Task<Result> DeleteVideoAsync(string videoFileId);
        Task<bool> IsVideoExists(string videoFileId);
    }
}
