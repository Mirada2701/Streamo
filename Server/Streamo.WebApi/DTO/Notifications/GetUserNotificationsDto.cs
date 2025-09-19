using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Notifications.Queries.GetUserNotifications;

namespace Streamo.WebApi.DTO.Notifications {
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
