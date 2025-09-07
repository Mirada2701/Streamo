using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Identity.Users.Commands.CreateUser;
using Streamo.Application.CQRS.SubscriptionUser.CheckSubscriptionUser;
using Streamo.Domain.Entities;

namespace Streamo.WebApi.DTO.Auth.Subscription
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