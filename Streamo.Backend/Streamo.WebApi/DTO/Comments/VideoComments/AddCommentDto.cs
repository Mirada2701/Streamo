using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Comments.VideoComments.Commands.AddComment;
using Streamo.Application.CQRS.Files.Photos.Queries.GetPhotoUrl;
using Streamo.WebApi.DTO.Files.Photo;

namespace Streamo.WebApi.DTO.Comments.VideoComments
{
    public class AddCommentDto : IMapWith<AddCommentCommand>
    {
        public string Content { get; set; } = string.Empty;
        public int? VideoId { get; set; } = null;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddCommentDto, AddCommentCommand>()
                .ForMember(query => query.Content, opt => opt.MapFrom(dto => dto.Content))
                .ForMember(query => query.VideoId, opt => opt.MapFrom(dto => dto.VideoId));
        }
    }
}
