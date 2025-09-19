using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Identity.Users.Commands.ChangeBanner;

namespace Streamo.WebApi.DTO.User
{
    public class ChangeBannerDto : IMapWith<ChangeBannerCommand>
    {
        public IFormFile? BannerFileId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ChangeBannerDto, ChangeBannerCommand>()
                .ForMember(command => command.BannerStream, opt => opt.MapFrom(dto => dto.BannerFileId.OpenReadStream()));
        }
    }
}
