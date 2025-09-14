using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.CreateUser;
using MEGUTube.Application.CQRS.SubscriptionUser.Queries;
using MEGUTube.Domain.Entities;

namespace MEGUTube.WebApi.DTO.Auth.Subscription
{
    public class GetSubscriptionUserDto : IMapWith<GetSubscriptionListQuery>
    {

        public int SubscribeUserTo { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetSubscriptionUserDto, GetSubscriptionListQuery>()

                 .ForMember(dest => dest.SubscriptionUserTo, opt => opt.MapFrom(dto => dto.SubscribeUserTo));


        }
    }
}