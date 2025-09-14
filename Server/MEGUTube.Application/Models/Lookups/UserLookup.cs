using AutoMapper;
using MEGUTube.Application.CQRS.Videos.Commands.UploadVideo;
using MEGUTube.Domain.Entities;
namespace MEGUTube.Application.Models.Lookups
{
    public record class UserLookup 
    {
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ChannelPhoto { get; set; }
        public string? Banner { get; set; }

        public IList<string>? Roles { get; set; }

        
    }
}
