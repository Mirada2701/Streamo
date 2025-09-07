using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Comments.VideoComments.Commands.DeleteComment;

namespace Streamo.WebApi.DTO.Comments.VideoComments
{
    public class DeleteCommentDto : IMapWith<DeleteCommentCommand>
    {
        public int? Id { get; set; } = null;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<DeleteCommentDto, DeleteCommentCommand>()
                .ForMember(query => query.CommentId, opt => opt.MapFrom(dto => dto.Id));
        }
    }
}
