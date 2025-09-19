using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Comments.VideoComments.Queries.GetCommentRepliesList;
using Streamo.Application.CQRS.Comments.VideoComments.Queries.GetCommentsList;

namespace Streamo.WebApi.DTO.Comments.VideoComments {
    public class GetCommentRepliesDto : IMapWith<GetCommentsListQuery> {
        public int VideoId { get; set; }
        public int RootCommentId { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        public void Mapping(Profile profile) {
            profile.CreateMap<GetCommentRepliesDto, GetCommentRepliesListQuery>()
                .ForMember(query => query.Page, opt => opt.MapFrom(dto => dto.Page))
                .ForMember(query => query.PageSize, opt => opt.MapFrom(dto => dto.PageSize))
                .ForMember(query => query.RootCommentId, opt => opt.MapFrom(dto => dto.RootCommentId))
                .ForMember(query => query.VideoId, opt => opt.MapFrom(dto => dto.VideoId));
        }
    }
}
