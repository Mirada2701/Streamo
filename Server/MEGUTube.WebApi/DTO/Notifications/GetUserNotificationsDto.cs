using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Notifications.Queries.GetUserNotifications;

namespace MEGUTube.WebApi.DTO.Notifications {
    public class GetUserNotificationsDto : IMapWith<GetUserNotificationsQuery> {
        public int Page { get; set; }
        public int PageSize { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<GetUserNotificationsDto, GetUserNotificationsQuery>()
                .ForMember(q => q.Page, opt => opt.MapFrom(dto => dto.Page))
                .ForMember(q => q.PageSize, opt => opt.MapFrom(dto => dto.PageSize));
        }
    }
}
