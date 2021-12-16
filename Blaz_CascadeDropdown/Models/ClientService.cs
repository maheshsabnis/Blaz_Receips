using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Json;


namespace Blaz_CascadeDropdown.Models
{
    public class ClientService
    {
        private HttpClient _httpClient;
        public ClientService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Product>> GetAsync(int? take,int? skip)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<Product>>($"http://localhost:5187/api/DBApi/{take}/{skip}");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
