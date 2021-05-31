using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.API.Response.Operations
{
    public class OperationResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("values")]
        public List<string> Values { get; set; }

        [JsonProperty("unit")]
        public List<string> Units { get; set; }
        
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }
}