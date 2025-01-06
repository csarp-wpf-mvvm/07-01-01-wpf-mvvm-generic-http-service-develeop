using Kreta.Shared.Models;

namespace Kreta.HttpService
{
    public interface IBaseService 
    {
        public Task<List<TEntityDto>> GetAllAsync<TEntityDto>() where TEntityDto : class, new();
    }
}
