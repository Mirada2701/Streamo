using MEGUTube.Domain.Entities.Abstract;

namespace MEGUTube.Domain.Entities
{
    public class VideoAccessModificatorEntity : BaseEntity
    {
        public string Modificator { get; set; } = string.Empty;
    }
}
