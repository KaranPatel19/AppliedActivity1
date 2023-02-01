
namespace AppliedActivity1.Services
{
	public class WebClientService : IWebClientService
	{
        public async Task<string> GetAsync(string uri)
        {
            try
            {
                HttpClient client;
                client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(uri);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
            }
            catch (Exception ex)
            {
                return null;12232
            }
        }
        public async Task<string> PostAsync(string uri, string body, string type)
        {
            throw new NotImplementedException();
        }
        public async Task<string> PutAsync(string uri, string body, string type)
        {
            throw new NotImplementedException();
        }
    }
}

