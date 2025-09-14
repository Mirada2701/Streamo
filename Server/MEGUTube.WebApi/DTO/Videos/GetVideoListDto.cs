using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetCommentsList;
using MEGUTube.Application.CQRS.Videos.Queries.GetVideoList;
using MEGUTube.WebApi.DTO.Comments.VideoComments;

namespace MEGUTube.WebApi.DTO.Videos
{
    public class GetVideoListDto : IMapWith<GetVideoListQuery>
    {
        public string? Name { get; set; } = null;
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetVideoListDto, GetVideoListQuery>()
                .ForMember(query => query.Page, opt => opt.MapFrom(dto => dto.Page))
                .ForMember(query => query.PageSize, opt => opt.MapFrom(dto => dto.PageSize))
                .ForMember(query => query.Name, opt => opt.MapFrom(dto => dto.Name));
        }
    }
}
