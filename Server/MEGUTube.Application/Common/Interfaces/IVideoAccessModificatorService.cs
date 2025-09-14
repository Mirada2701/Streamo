namespace MEGUTube.Application.Common.Interfaces
{
    public interface IVideoAccessModificatorService
    {
        Task CreateAccessModificatorAsync(string modificatorName);
    }
}
