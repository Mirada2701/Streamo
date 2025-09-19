using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.Common.Interfaces {
    public interface IIdentityService {
        Task<(Result Result, UserLookup User)> CreateUserAsync(string password, string email, string firstName, string lastName, Guid channelPhotoFileId);
        Task<(Result Result, ApplicationUser User)> CreateUserAsync(string email, string firstName, string lastName, Guid channelPhotoFileId);
        Task<(Result Result, ApplicationUser User)> CreateVerifiedUserAsync(string email, string firstName, string lastName, Guid channelPhotoFileId);
        Task<Result> CreateRoleAsync(string roleName);
        Task<Result> AddToRoleAsync(int userId, string roleName);
        Task<(Result Result, IList<string> Roles)> GetUserRolesAsync(int userId);
      Task<(Result Result, UserLookup userLookup)> GetUserLookupAsync(int userId);


    }
}
