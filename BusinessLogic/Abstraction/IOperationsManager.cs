using DomainModel.API.Request.Operations;
using DomainModel.API.Response.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstraction
{
    public interface IOperationsManager
    {
        List<OperationResponse> GetAllOperations();
        OperationResponse GetOperation(string key);
        OperationResponse CreateOpeartion(OperationRequest request);
        OperationResponse UpdateOperation(OperationUpdateRequest request);
        OperationResponse DeleteOperation(string key);
    }
}
