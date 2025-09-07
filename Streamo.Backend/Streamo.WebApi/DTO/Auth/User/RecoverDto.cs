using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Identity.Users.Commands.Recover;
using Streamo.Application.CQRS.Identity.Users.Commands.SignInUser;

namespace Streamo.WebApi.DTO.Auth.User
{
    public class RecoverDto : IMapWith<RecoverCommand>
    { 
    
        public string Email { get; set; } = null!;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RecoverDto, RecoverCommand>()
                .ForMember(command => command.Email, opt => opt.MapFrom(dto => dto.Email));
        }
    }
}


