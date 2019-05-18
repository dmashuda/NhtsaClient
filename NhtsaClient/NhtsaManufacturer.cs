using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhtsa
{
    public class NhtsaManufacturer
    {
        public string Country { get; set; }
        
        [JsonProperty(PropertyName = "Mfr_CommonName")]
        public string MfrCommonName { get; set; }
        
        [JsonProperty(PropertyName = "Mfr_ID")]
        public int MfrId { get; set; }
        
        [JsonProperty(PropertyName = "Mfr_Name")]
        public string MfrName { get; set; }
        public IEnumerable<NhtsaVehicleType> VehicleTypes { get; set; }
    }

    public class NhtsaVehicleType
    {
        public bool IsPrimary { get; set; }
        public string Name { get; set; }
    }
}