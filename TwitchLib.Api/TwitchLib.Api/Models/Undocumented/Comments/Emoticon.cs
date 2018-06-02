using Newtonsoft.Json;

namespace TwitchLib.Api.Models.Undocumented.Comments
{
    public class Emoticon
    {
        [JsonProperty(PropertyName = "emoticon_id")]
        public string EmoticonId { get; set; }
        [JsonProperty(PropertyName = "emoticon_set_id")]
        public string EmoticonSetId { get; set; }
    }
}