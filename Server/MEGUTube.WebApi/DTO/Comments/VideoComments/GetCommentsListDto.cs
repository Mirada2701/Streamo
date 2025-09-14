using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetCommentsList;

namespace MEGUTube.WebApi.DTO.Comments.VideoComments
{
    public class GetCommentsListDto : IMapWith<GetCommentsListQuery>
    {
        public int VideoId { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetCommentsListDto, GetCommentsListQuery>()
                .ForMember(query => query.Page, opt => opt.MapFrom(dto => dto.Page))
                .ForMember(query => query.PageSize, opt => opt.MapFrom(dto => dto.PageSize))
                .ForMember(query => query.VideoId, opt => opt.MapFrom(dto => dto.VideoId));
        }
    }
}
