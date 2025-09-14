using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.CreateUser;
using MEGUTube.Application.CQRS.SubscriptionUser.DeleteSubscriptionUserCommand;
using MEGUTube.Domain.Entities;

namespace MEGUTube.WebApi.DTO.Auth.User
{
    public class DeleteSubscriptionUserDto : IMapWith<DeleteSubscriptionUserCommand>
    {

        public int SubscribeTo { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<DeleteSubscriptionUserDto, DeleteSubscriptionUserCommand>()

                 .ForMember(dest => dest.Subscriber, opt => opt.MapFrom(dto => dto.SubscribeTo));


        }
    }
}