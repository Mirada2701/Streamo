using FluentValidation;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.CQRS.Identity.Users.Commands.UpdateChannelImage;
using Streamo.Application.CQRS.Videos.Commands.UpdateVideo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamo.Application.CQRS.Identity.Users.Commands.UpdateChannelImage
{
    public class UpdateChannelImageCommandValidation : AbstractValidator<UpdateChannelImageCommand>
    {
        public UpdateChannelImageCommandValidation(IPhotoService photoService)
        {

            RuleFor(x => x.UserId)
                   .NotEmpty().WithMessage("User ID cannot be empty");

 
            RuleFor(x => x.ChannelPhotoFile)
             .NotNull()
            .MustAsync(async (s, cancellation) =>
            {
                if (!await photoService.IsFileImageAsync(s))
                    return false;
                else return true;
            }).WithMessage("Channel Photo File  mast be image");
 


        }


    }
}
