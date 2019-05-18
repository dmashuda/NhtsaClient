using Newtonsoft.Json;

namespace Nhtsa
{
    public class NhtsaModel
    {
        [JsonProperty(PropertyName = "Make_ID")]
        public int MakeId { get; set; }
        
        [JsonProperty(PropertyName = "Make_Name")]
        public string MakeName { get; set; }
        
        [JsonProperty(PropertyName = "Model_ID")]
        public int ModelId { get; set; }
        
        [JsonProperty(PropertyName = "Model_Name")]
        public string ModelName { get; set; }
    }
}