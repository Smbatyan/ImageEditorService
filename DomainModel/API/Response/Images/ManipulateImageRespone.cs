using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.API.Response
{
    public class ManipulateImageRespone
    {
        public string ImageBase64 { get; set; }

        public List<ManipulateImageActionResponse> Actions { get; set; }
    }
}