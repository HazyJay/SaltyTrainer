﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Models.v5.Bits
{
    public class ImageLinks
    {
        [JsonProperty(PropertyName = "1")]
        public string One { get; set; }
        [JsonProperty(PropertyName = "2")]
        public string Two { get; set; }
        [JsonProperty(PropertyName = "3")]
        public string Three { get; set; }
        [JsonProperty(PropertyName = "4")]
        public string Four { get; set; }
        [JsonProperty(PropertyName = "1.5")]
        public string OnePointFive { get; set; }
    }
}
