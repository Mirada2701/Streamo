using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MEGUTube.Application.CQRS.Files.Photos.Commands.UploadPhoto;
using MEGUTube.Application.CQRS.Files.Photos.Queries.GetPhotoUrl;
using MEGUTube.WebApi.DTO.Files.Photo;
using WebShop.Domain.Constants;

namespace MEGUTube.WebApi.Controllers
{
    public class PhotoController : BaseController
    {
        private readonly IMapper mapper;

        public PhotoController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        
        [HttpGet("{PhotoId}/{Size}")]
        public async Task<ActionResult> GetPhotoUrl([FromRoute]GetPhotoUrlDto dto)
        {
            //var query = mapper.Map<GetPhotoUrlQuery>(dto);
            //GetPhotoUrlQueryResult getPhotoUrlResult = await Mediator.Send(query);

            var request = HttpContext.Request;

            // Get the scheme (HTTP or HTTPS)
            string scheme = request.Scheme;

            // Get the host (domain name)
            string host = request.Host.Value;

            // Combine scheme and host to get the full domain
            string domain = $"{scheme}://{host}";
            
            String url = $"{domain}/photos/{dto.Size}_{dto.PhotoId}.webp";

            return Redirect(url);
        }

        [Authorize(Roles = Roles.User)]
        [HttpPost]
        public async Task<ActionResult> UploadPhoto([FromForm] UploadPhotoDto dto)
        {
            var command = mapper.Map<UploadPhotoCommand>(dto);
            var photoId = await Mediator.Send(command);

            return Ok(photoId);
        }
    }
}
