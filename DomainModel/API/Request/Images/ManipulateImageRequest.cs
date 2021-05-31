using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.API.Request
{
    public class ManipulateImageRequest
    {
        [JsonProperty("imageFile", Required = Required.Always)]
        public IFormFile ImageFile { get; set; }

        [JsonProperty("operations", Required = Required.Always)]
        public List<ManipulateImageOperationRequest> Operations { get; set; }
    }
}
