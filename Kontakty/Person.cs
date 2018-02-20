using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using SQLite;

namespace Kontakty
{
	public class Person
	{
        [JsonProperty("postId")]
		public int postId { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
		public string name { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("body")]
        public string body { get; set; }



		public override string ToString()
		{
            return name + " " + email + " " + body;
		}
	}
}
