using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.CreateUser;
using MEGUTube.Application.CQRS.SubscriptionUser.AddSubscriptionUser;
using MEGUTube.Domain.Entities;

namespace MEGUTube.WebApi.DTO.Auth.Subscription
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