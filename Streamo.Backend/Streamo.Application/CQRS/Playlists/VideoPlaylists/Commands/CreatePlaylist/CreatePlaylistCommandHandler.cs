using MediatR;
using Streamo.Application.Common.DbContexts;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.CQRS.Files.Photos.Commands.UploadPhoto;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Playlists.VideoPlaylists.Commands.CreatePlaylist {
    public class CreatePlaylistCommandHandler : IRequestHandler<CreatePlaylistCommand, VideoPlaylistLookup> {
        private readonly IApplicationDbContext dbContext;
        private readonly IDateTimeService dateTimeService;
        private readonly IMediator mediator;

        public CreatePlaylistCommandHandler(IApplicationDbContext dbContext, IDateTimeService dateTimeService, IMediator mediator) {
            this.dbContext = dbContext;
            this.dateTimeService = dateTimeService;
            this.mediator = mediator;
        }

        public async Task<VideoPlaylistLookup> Handle(CreatePlaylistCommand request, CancellationToken cancellationToken) {
            Guid? imageId = null;
            // if user provide playlist preview image - set it
            if (request.PreviewImageStream is not null) {
                imageId = Guid.Parse(await mediator.Send(new UploadPhotoCommand() {
                    Source = request.PreviewImageStream
                }));
            }

            var playlist = new VideoPlaylistEntity() {
                Creator = request.User,
                Title = request.Title,
                DateCreated = dateTimeService.Now,
                PreviewImage = imageId
            };

            dbContext.VideoPlaylists.Add(playlist);

            await dbContext.SaveChangesAsync(cancellationToken);

            return new VideoPlaylistLookup() {
                Id = playlist.Id,
                Preview = playlist.PreviewImage.ToString(),
                Title = playlist.Title,
                TotalCountVideos = 0
            };
        }
    }
}
