using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Files.Photos.Queries.GetPhotoUrl;
using Streamo.Application.CQRS.Identity.Users.Commands.BanUser;
using Streamo.Application.CQRS.Identity.Users.Commands.Recover;
using Streamo.WebApi.DTO.Auth.User;

namespace Streamo.WebApi.DTO.Admin
{
    public class BanUserDto : IMapWith<BanUserCommand>
    { 
        public int UserId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<BanUserDto, BanUserCommand>()
                .ForMember(command => command.UserId, opt => opt.MapFrom(dto => dto.UserId));
        }

    }
}
