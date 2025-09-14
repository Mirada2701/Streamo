
using Ardalis.GuardClauses;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MEGUTube.Application.Common.DbContexts;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.ChangeBanner
{
    public class ChangeBannerCommandHandler : IRequestHandler<ChangeBannerCommand, Unit>
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly IPhotoService _photoService;

        public ChangeBannerCommandHandler(IApplicationDbContext dbContext, IPhotoService photoService)
        {
            _dbContext = dbContext;
            _photoService = photoService;
        }

        public async Task<Unit> Handle(ChangeBannerCommand request, CancellationToken cancellationToken)
        {

            var uploadResult = await _photoService.UploadPhoto(request.BannerStream);

            await _photoService.DeletePhotoAsync(request.Requester.BannerFileId.ToString());

            request.Requester.BannerFileId = Guid.Parse(uploadResult.PhotoId);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
