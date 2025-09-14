using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.CreateUser;
using MEGUTube.Application.CQRS.SubscriptionUser.CheckSubscriptionUser;
using MEGUTube.Domain.Entities;

namespace MEGUTube.WebApi.DTO.Auth.Subscription
{
    public class CheckSubscribeUserDto : IMapWith<CheckSubscriptionUserCommand>
    {

        public int SubscribeTo { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CheckSubscribeUserDto, CheckSubscriptionUserCommand>()

                 .ForMember(dest => dest.SubscriptionUserTo, opt => opt.MapFrom(dto => dto.SubscribeTo));


        }
    }
}