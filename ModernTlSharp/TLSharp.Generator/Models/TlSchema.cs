using Newtonsoft.Json;
using System.Collections.Generic;

namespace ModernTlSharp.TLSharp.Generator.Models
{
    internal class TlSchema
    {
        [JsonProperty("constructors")]
        public List<TlConstructor> Constructors { get; set; }

        [JsonProperty("methods")]
        public List<TlMethod> Methods { get; set; }
    }
}
