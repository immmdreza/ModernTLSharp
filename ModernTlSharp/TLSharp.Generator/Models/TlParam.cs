using Newtonsoft.Json;

namespace ModernTlSharp.TLSharp.Generator.Models
{
    internal class TlParam
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
