using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.VerifyMail;

namespace MEGUTube.WebApi.DTO.Auth.User {
    public class VerifyUserDto : IMapWith<VerifyMailCommand> { 
        public string VerificationToken { get; set; } = null!;
        public string SecretPhrase { get; set; } = null!;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<VerifyUserDto, VerifyMailCommand>()
                .ForMember(command => command.VerificationToken, opt => opt.MapFrom(dto => dto.VerificationToken))
                .ForMember(command => command.SecretPhrase, opt => opt.MapFrom(dto => dto.SecretPhrase));
        }
    }
}
