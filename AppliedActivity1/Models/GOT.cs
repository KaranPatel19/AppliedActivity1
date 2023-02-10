
namespace AppliedActivity1.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class GOT
    {
        public string name{ get; set; }
        public string slug { get; set; }
        public string house { get; set; }
        public string character { get; set; }

        public GOT(string name, string slug, string house, string character)
        {
            this.name = name;
            this.slug = slug;
            this.house = house;
            this.character = character;
        }
        
    }
}

