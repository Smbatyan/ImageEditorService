using DomainModel.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.API.Request.Operations
{
    public class OperationRequest
    {
        [JsonProperty("key", Required = Required.Always)]
        public string Key { get; set; }

        [JsonProperty("values")]
        public List<string> Values { get; set; }

        [JsonProperty("unit")]
        public List<string> Units { get; set; }
    }
}
