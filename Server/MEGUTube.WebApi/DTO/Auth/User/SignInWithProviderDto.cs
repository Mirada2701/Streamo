using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.SignInWithProvider;

namespace MEGUTube.WebApi.DTO.Auth.User {
    public class SignInWithProviderDto : IMapWith<SignInWithProviderCommand> {
        public string ProviderToken { get; set; } = null!;
        public string Provider { get; set; } = null!;

        public void Mapping(Profile profile) {
            profile.CreateMap<SignInWithProviderDto, SignInWithProviderCommand>()
                .ForMember(command => command.ProviderToken, opt => opt.MapFrom(dto => dto.ProviderToken))
                .ForMember(command => command.Provider, opt => opt.MapFrom(dto => dto.Provider));
        }
    }
}
