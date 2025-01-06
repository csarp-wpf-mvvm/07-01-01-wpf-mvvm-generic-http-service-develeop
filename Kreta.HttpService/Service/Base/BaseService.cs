using Kreta.Shared.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Kreta.HttpService.Service.Base
{
    public class BaseService : IBaseService
    {
        protected readonly HttpClient _httpClient;

        public BaseService()
        {
            _httpClient = new HttpClient();
        }
        public BaseService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
                _httpClient = httpClientFactory.CreateClient("KretaApi");
            else
                _httpClient = new HttpClient();
        }
        public async Task<List<TEntityDto>> GetAllAsync<TEntityDto>() where TEntityDto : class, new()
        {
            try
            {
                List<TEntityDto>? resultDto = await _httpClient.GetFromJsonAsync<List<TEntityDto>>($"api/{GetApiName<TEntityDto>()}");
                if (resultDto is not null)
                {
                    return resultDto;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return new List<TEntityDto>();
        }

        private object GetApiName<TEntityDto>() where TEntityDto : class, new()
        {
            string result = typeof(TEntityDto).Name;
            if (result.Length < 3)
                return result;
            else
                return result.Remove(result.Length - 3);
        }
    }
}
