using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Comments.VideoComments.Commands.AddComment;
using MEGUTube.Application.CQRS.Files.Photos.Queries.GetPhotoUrl;
using MEGUTube.WebApi.DTO.Files.Photo;

namespace MEGUTube.WebApi.DTO.Comments.VideoComments
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
