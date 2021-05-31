using BusinessLogic.Abstraction;
using DomainModel.API.Request.Operations;
using DomainModel.API.Response.Operations;
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
    public class OperationsController : ControllerBase
    {
        private readonly IOperationsManager _operationsManager;

        public OperationsController(IOperationsManager operationsManager)
        {
            _operationsManager = operationsManager;
        }

        #region GET

        [HttpGet]
        public IActionResult GetOperations()
        {
            List<OperationResponse> respone = _operationsManager.GetAllOperations();

            return Ok(respone);
        }

        [HttpGet("{key}")]
        public IActionResult GetOperation(string key)
        {
            OperationResponse respone = _operationsManager.GetOperation(key);

            return Ok(respone);
        }

        #endregion

        #region CREATE/UPDATE

        [HttpPost]
        public IActionResult GetOperation(OperationRequest request)
        {
            OperationResponse respone = _operationsManager.CreateOpeartion(request);

            return Ok(respone);
        }

        [HttpPatch("{key}")]
        public IActionResult UpdateOperation(string key, OperationUpdateRequest request) // (JsonPatchDocument<T>) Not this time :)
        {
            request.Key = key;
            OperationResponse respone = _operationsManager.UpdateOperation(request);

            return Ok(respone);
        }

        [HttpDelete("{key}")]
        public IActionResult DeleteOperation(string key)
        {
            OperationResponse respone = _operationsManager.DeleteOperation(key);

            return Ok(respone);
        }

        #endregion
    }
}
