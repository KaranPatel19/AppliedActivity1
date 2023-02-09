using System;
namespace AndroidAppliedActivity1.Model
{
	public class bikes
	{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class License
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Location
        {
            public string city { get; set; }
            public string country { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class Network
        {
            public List<string> company { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public Location location { get; set; }
            public string name { get; set; }
            public string source { get; set; }
            public string gbfs_href { get; set; }
            public License license { get; set; }
            public bool? ebikes { get; set; }
        }

        public class Root
        {
            public List<Network> networks { get; set; }
        }


    }
}

