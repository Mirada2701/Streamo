using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Identity.Users.Commands.CreateUser;
using Streamo.Application.CQRS.SubscriptionUser.Queries;
using Streamo.Domain.Entities;

namespace Streamo.WebApi.DTO.Auth.Subscription
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