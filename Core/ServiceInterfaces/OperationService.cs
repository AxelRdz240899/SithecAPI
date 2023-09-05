using Core.BusinessModels.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ServiceInterfaces
{
    public interface IOperationService
    {
        public double MakeOperation(double num1, double num2, char operationSymbol);
    }
}
