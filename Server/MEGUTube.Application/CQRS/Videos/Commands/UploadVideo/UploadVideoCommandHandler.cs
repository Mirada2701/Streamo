using Ardalis.GuardClauses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MEGUTube.Application.Common.DbContexts;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.CQRS.Videos.Notifications.VideoCreated;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Videos.Commands.UploadVideo {
    public class UploadVideoCommandHandler : IRequestHandler<UploadVideoCommand, VideoLookup> {
        private readonly IVideoService _videoService;
        private readonly IPhotoService _photoService;
        private readonly IDateTimeService _dateTimeService;
        private readonly IApplicationDbContext _dbContext;
        private readonly IMediator _mediator;

        public UploadVideoCommandHandler(IVideoService videoService, IPhotoService photoService, IDateTimeService dateTimeService, IApplicationDbContext dbContext, IMediator mediator) {
            _videoService = videoService;
            _photoService = photoService;
            _dateTimeService = dateTimeService;
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<VideoLookup> Handle(UploadVideoCommand request, CancellationToken cancellationToken) {
            var videoUploadResult = await _videoService.UploadVideoAsync(request.Source);
            var photoUploadResult = await _photoService.UploadPhoto(request.PreviewPhotoSource);
            var accessModificator = await _dbContext.VideoAccessModificators.Where(v => v.Modificator == request.AccessModificator).FirstOrDefaultAsync();

            if (accessModificator == null) {
                throw new NotFoundException(request.AccessModificator, nameof(VideoAccessModificatorEntity));
            }

            var video = new VideoEntity() {
                Name = request.Name,
                Description = request.Description,
                VideoFileId = Guid.Parse(videoUploadResult.VideoFileId),
                PreviewPhotoFileId = Guid.Parse(photoUploadResult.PhotoId),
                Creator = request.Creator,
                AccessModificator = accessModificator,
                DateCreated = _dateTimeService.Now,
            };

            _dbContext.Videos.Add(video);
            await _dbContext.SaveChangesAsync(cancellationToken);

            if (video.AccessModificator.Modificator.ToLower() != "private") {
                await _mediator.Publish(new VideoCreatedNotification() {
                    Video = video,
                });
            }

            var videoLookup = new VideoLookup() {
                Id = video.Id,
                Name = video.Name,
                Description = video.Description,
                VideoFile = video.VideoFileId,
                AccessModificator = video.AccessModificator.Modificator,
                PreviewPhotoFile = video.PreviewPhotoFileId,
                DateCreated = video.DateCreated,
                DateModified = video.DateModified,
                Views = video.Views,
                Creator = new UserLookup() {
                    UserId = video.Creator!.Id,
                    FirstName = video.Creator.FirstName,
                    LastName = video.Creator.LastName,
                    ChannelPhoto = video.Creator.ChannelPhotoFileId.ToString(),
                }
            };

            return videoLookup;
        }
    }
}
