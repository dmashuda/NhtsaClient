using Newtonsoft.Json;

namespace Nhtsa
{
    public class NhtsaMake
    {
        [JsonProperty(PropertyName = "Make_ID")]
        public int MakeId { get; set; }
        
        [JsonProperty(PropertyName = "Make_Name")]
        public string MakeName { get; set; }
    }
}