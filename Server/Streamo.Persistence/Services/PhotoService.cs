using Microsoft.Extensions.Options;
using Minio.Exceptions;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.Common.Models;
using Streamo.Persistence.Settings.Configurations;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;

namespace Streamo.Persistence.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IFileService _fileService;
        private readonly PhotoSettings _options;

        public PhotoService(IFileService fileService, IOptions<PhotoSettings> options)
        {
            _fileService = fileService;
            _options = options.Value;
        }
        private string GetPhotoName(string photoId, int photoSize) {
            return $"{photoId}_{photoSize}";
        }

        public async Task<(Result Result, string Url)> GetPhotoUrl(string photoId)
        {
            var getPhotoUrl = await _fileService.GetFileUrlAsync("photos", photoId, "image/webp");
            return getPhotoUrl;
        }

        public async Task<(Result Result, string Url)> GetPhotoUrl(string photoId, int size) {
            var photoUrl = await _fileService.GetFileUrlAsync("photos", GetPhotoName(photoId, size), "image/webp");
            //string? filename = $"{size}_{photoId}"; //GetPhotoName(photoId, size);

            return photoUrl;
        }

        public async Task<(Result Result, string? PhotoId)> UploadPhoto(Stream source)
        {
            using var image = await Image.LoadAsync(source);
            var encoder = new WebpEncoder { Quality = _options.PhotoQuallity };
            var imageName = Guid.NewGuid().ToString();
            foreach (var size in _options.ChannelPhotoWidths) {
                // resize image
                var resizedImage = image.Clone(x => x.Resize(size, 0));

                // process image to virtual stream
                //using var ms = new MemoryStream();
                string root = Directory.GetCurrentDirectory();

                var filename = $"{size}_{imageName}";

                string imagePath = Path.Combine(root, "photos", filename);

                await resizedImage.SaveAsWebpAsync(imagePath+".webp");
            }
            
            return (Result.Success(), imageName);
        }

        public async Task<(Result Result, System.Drawing.Size Dimensions)> GetPhotoDimensionsAsync(Stream source) {
            var info = await Image.IdentifyAsync(source);
            source.Position = 0; // reset stream pointer position
            return (Result.Success(), new System.Drawing.Size(width: info.Width, height: info.Height));
        }

        public async Task<bool> IsFileImageAsync(Stream source) {
            try {
                var info = await Image.IdentifyAsync(source);
                source.Position = 0; // reset stream pointer position
                return true;
            }
            catch (UnknownImageFormatException) {
                return false;
            }
        }

        public async Task DeletePhotoAsync(string photoId)
        {
            foreach (var size in _options.ChannelPhotoWidths)   
            {
                try
                {
                    await _fileService.DeleteFileAsync("photos", $"{photoId}_{size}");
                }
                catch (InvalidObjectNameException) { }
            }
        }
    }
}
