using BusinessLogic.Abstraction;
using DomainModel.API.Request;
using DomainModel.API.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageEditorServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageEditorController : ControllerBase
    {
        private readonly IManipulateImageManger _manipulateImageManger;
        public ImageEditorController(IManipulateImageManger manipulateImageManger)
        {
            _manipulateImageManger = manipulateImageManger;
        }

        [HttpPost("Manipulate")]
        public IActionResult ManipulateImage([FromBody]List<ManipulateImageRequest> request)
        {
            List<ManipulateImageRespone> respone = _manipulateImageManger.Manipulate(request);

            return Ok(respone);
        }
    }
}
