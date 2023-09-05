using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessModels.Operation
{
    [OperationSymbol('+')]
    public class AddOperation : IOperation
    {
        public double ExecuteOperation(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
