namespace Enunmo.Models
{ 
    using Newtonsoft.Json;
    public class Translations
    {
        [JsonProperty(PropertyName = "de")]
        public string Alemám { get; set; }

        [JsonProperty(PropertyName = "es")]
        public string Español { get; set; }

        [JsonProperty(PropertyName = "fr")]
        public string Francés { get; set; }

        [JsonProperty(PropertyName = "ja")]
        public string Japonés { get; set; }

        [JsonProperty(PropertyName = "it")]
        public string Italiano { get; set; }

        [JsonProperty(PropertyName = "br")]
        public string Brasileiro { get; set; }

        [JsonProperty(PropertyName = "pt")]
        public string Portugués { get; set; }

        [JsonProperty(PropertyName = "nl")]
        public string Holandés { get; set; }

        [JsonProperty(PropertyName = "hr")]
        public string Croata { get; set; }

        [JsonProperty(PropertyName = "fa")]
        public string Persa  { get; set; }
    }
}