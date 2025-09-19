using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Identity.Users.Commands.CreateUser;
using Streamo.Application.CQRS.SubscriptionUser.DeleteSubscriptionUserCommand;
using Streamo.Domain.Entities;

namespace Streamo.WebApi.DTO.Auth.User
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