using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RedTubeAPI.NET.Repository
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Star
    {
        [JsonProperty("star_name")]
        public string Name { get; set; }

        [JsonProperty("star_url")]
        public string WebProfile { get; set; }

        [JsonProperty("star_thumb")]
        public string Thumbnail { get; set; }


        public override string ToString()
        {
            return string.Format(
                "[Star: Name={0}, WebProfile={1}, Thumbnail={2}]",
                Name, WebProfile, Thumbnail
            );
        }
    }
}