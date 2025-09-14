using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Files.Photos.Queries.GetPhotoUrl;
using MEGUTube.Application.CQRS.Identity.Users.Commands.BanUser;
using MEGUTube.Application.CQRS.Identity.Users.Commands.Recover;
using MEGUTube.WebApi.DTO.Auth.User;

namespace MEGUTube.WebApi.DTO.Admin
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
