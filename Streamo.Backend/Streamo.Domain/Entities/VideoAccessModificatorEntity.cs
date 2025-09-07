using Streamo.Domain.Entities.Abstract;

namespace Streamo.Domain.Entities
{
    public class VideoAccessModificatorEntity : BaseEntity
    {
        public string Modificator { get; set; } = string.Empty;
    }
}
