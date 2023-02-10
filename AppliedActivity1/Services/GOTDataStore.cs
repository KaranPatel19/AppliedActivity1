using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using AppliedActivity1.Services;
using Newtonsoft.Json.Linq;
using AppliedActivity1.Models;
using System.Dynamic;

namespace AppliedActivity1.Services
{
    class GOTDataStore : IGOTDataStore<GOT>
    {
        private static string API => "https://api.gameofthronesquotes.xyz/v1/random";

        public async Task<IEnumerable<GOT>> GetGOTAsync(int count)
        {
            var service = DependencyService.Get<IWebClientService>();
            var json = await service.GetAsync($"{API}/{count}");

            var quotes = GOTBuilder(json);

            return quotes;
        }
        private List<GOT> GOTBuilder(string json)
        {

            var response = JsonConvert.DeserializeObject<dynamic>(json);
            
            var quotes = new List<GOT>();

            foreach (var data in response)
            {
                Console.WriteLine("Response1" + data);
                var name = data.character.name.ToString();
                var slug = data.character.slug.ToString();
                var sentence = data.sentence.ToString();
              
                quotes.Add(new GOT(name, slug, sentence));
                Console.WriteLine("Response2" + name);
            }

            return quotes;
        }

        public static class UserBuilder
        {

        }
    }
}