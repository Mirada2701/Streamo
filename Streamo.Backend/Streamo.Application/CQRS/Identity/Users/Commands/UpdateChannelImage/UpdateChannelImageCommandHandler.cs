using Ardalis.GuardClauses;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.CQRS.Files.Photos.Commands.UploadSquarePhoto;
using Streamo.Application.CQRS.Identity.Users.Commands.UpdateUser;
using Streamo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamo.Application.CQRS.Identity.Users.Commands.UpdateChannelImage
{
    public class UpdateChannelImageCommandHandler : IRequestHandler<UpdateChannelImageCommand, int>
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMediator _mediator;
        private readonly IPhotoService _photoService;
        public UpdateChannelImageCommandHandler(UserManager<ApplicationUser> userManager, IMediator mediator, IPhotoService photoService)
        {
            _userManager = userManager;
            _photoService = photoService;
            _mediator = mediator;
        }


        public async Task<int> Handle(UpdateChannelImageCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
 
            if (user == null)
            {
                throw new NotFoundException("User", request.UserId.ToString());
            }
            if (!string.IsNullOrEmpty(user.ChannelPhotoFileId.ToString()))
            {
                await _photoService.DeletePhotoAsync(user.ChannelPhotoFileId.ToString());   

            }
            var photoUploadResult = await _mediator.Send(new UploadSquarePhotoCommand() { Source = request.ChannelPhotoFile });

            if (photoUploadResult == null || !Guid.TryParse(photoUploadResult, out var photoId))
            {
                throw new InvalidOperationException("Failed to upload or parse the photo result.");
            }

            user.Id = request.UserId;   
            user.ChannelPhotoFileId = photoId;

            await _userManager.UpdateAsync(user);

            return user.Id;
        }
    }
}
