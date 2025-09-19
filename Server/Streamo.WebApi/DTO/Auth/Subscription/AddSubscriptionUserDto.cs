using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Identity.Users.Commands.CreateUser;
using Streamo.Application.CQRS.SubscriptionUser.AddSubscriptionUser;
using Streamo.Domain.Entities;

namespace Streamo.WebApi.DTO.Auth.Subscription
{
    public class AddSubscriptionUserDto : IMapWith<AddSubscriptionUserCommand>
    {

        public int SubscribeTo { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddSubscriptionUserDto, AddSubscriptionUserCommand>()

                 .ForMember(dest => dest.Subscriber, opt => opt.MapFrom(dto => dto.SubscribeTo));


        }
    }
}