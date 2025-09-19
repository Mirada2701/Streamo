using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Identity.Users.Commands.GetChannelInfo;


namespace Streamo.WebApi.DTO.Auth.Subscription
{
    public class GetChannelInfoDto : IMapWith<GetChannelInfoCommand>
    {

        public int ChannelId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetChannelInfoDto, GetChannelInfoCommand>()

                 .ForMember(dest => dest.UserId, opt => opt.MapFrom(dto => dto.ChannelId));


        }
    }
}