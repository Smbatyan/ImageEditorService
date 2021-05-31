using DomainModel.API.Request;
using DomainModel.API.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstraction
{
    public interface IManipulateImageManger
    {
        List<ManipulateImageRespone> Manipulate(List<ManipulateImageRequest> request);
    }
}
