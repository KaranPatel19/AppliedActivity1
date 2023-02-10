
namespace AppliedActivity1.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class GOT
    {
        public string name{ get; set; }
        public string slug { get; set; }
        public string sentence { get; set; }
        

        public GOT(string name, string slug, string sentence)
        {
            this.name = name;
            this.slug = slug;
            this.sentence = sentence;
        }
        
    }
}

