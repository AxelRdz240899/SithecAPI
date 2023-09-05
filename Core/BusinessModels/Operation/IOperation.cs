using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessModels.Operation
{
    public class OperationSymbol : Attribute
    {
        public char SymbolValue { get; set; }

        public OperationSymbol(char value)
        {
            SymbolValue = value;
        }
    }

    public interface IOperation
    {
        public double ExecuteOperation(double num1, double num2);
    }
}
