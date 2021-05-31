using BusinessLogic.Abstraction;
using DomainModel.API.Request.Operations;
using DomainModel.API.Response.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementation
{
    public class OperationsManager : IOperationsManager
    {
        public OperationResponse CreateOpeartion(OperationRequest request)
        {
            throw new NotImplementedException();
        }

        public OperationResponse DeleteOperation(string key)
        {
            throw new NotImplementedException();
        }

        public List<OperationResponse> GetAllOperations()
        {
            throw new NotImplementedException();
        }

        public OperationResponse GetOperation(string key)
        {
            throw new NotImplementedException();
        }

        public OperationResponse UpdateOperation(OperationUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
