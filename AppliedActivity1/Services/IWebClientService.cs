 namespace AppliedActivity1.Services
{
    public class IWebClientService
    {
        public IWebClientService()
        {
            Task<string> GetAsync(string uri);
            Task<string> PostAsync(string uri, string body, string type);
            Task<string> PostAsync(string uri, string body, string type);
        }
    }
}

