using Microsoft.EntityFrameworkCore;
using Streamo.Application.Common.DbContexts;
using Streamo.Application.Common.Interfaces;
using Streamo.Domain.Entities;
using WebShop.Application.Common.Exceptions;

namespace Streamo.Persistence.Services
{
    public class VideoAccessModificatorService : IVideoAccessModificatorService
    {
        private readonly IApplicationDbContext _dbContext;

        public VideoAccessModificatorService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAccessModificatorAsync(string modificatorName)
        {
            if(await _dbContext.VideoAccessModificators.FirstOrDefaultAsync(v => v.Modificator == modificatorName) != null)
            {
                throw new AlreadyExistsException(modificatorName, nameof(VideoAccessModificatorEntity));
            }

            var videoAccessModificator = new VideoAccessModificatorEntity()
            {
                Modificator = modificatorName,
            };

            await _dbContext.VideoAccessModificators.AddAsync(videoAccessModificator);
            await _dbContext.SaveChangesAsync(CancellationToken.None);
        }
    }
}
