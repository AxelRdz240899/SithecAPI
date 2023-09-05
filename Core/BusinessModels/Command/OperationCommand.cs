using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessModels.Command
{
    public static class OperationSymbolEnumerator
    {
        public const char Add = '+';
        public const char Substract = '-';
        public const char Multiply = '*';
        public const char Divide = '/';
    }

    public class OperationCommand
    {
        [Required]
        public double num1 { get; set; }
        [Required]
        public double num2 { get; set; }
        [Required]
        public char operationSymbol { get; set; }

        public void Validate()
        {
            if (operationSymbol != OperationSymbolEnumerator.Add && operationSymbol != OperationSymbolEnumerator.Substract && operationSymbol != OperationSymbolEnumerator.Multiply && operationSymbol != OperationSymbolEnumerator.Divide)
            {
                throw new Exception($"The operation must be one of this values: {OperationSymbolEnumerator.Add}, {OperationSymbolEnumerator.Substract}, {OperationSymbolEnumerator.Multiply}, {operationSymbol != OperationSymbolEnumerator.Divide}");
            }
        }

    }
}
