using Core.BusinessModels.Command;
using Core.BusinessModels.Operation;
using Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class OperationService : IOperationService
    {
        private readonly OperationHandler _operationHandler;

        public OperationService()
        {
            _operationHandler = new OperationHandler();
        }

        public double MakeOperation(double num1, double num2, char operationSymbol)
        {
            return _operationHandler.MakeOperation(num1, num2, operationSymbol);
        }
    }
}
