using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessModels.Command
{
    public class OperationCommand
    {
        [Required]
        public double num1 { get; set; }
        [Required]
        public double num2 { get; set; }
        [Required]
        public char operationSymbol { get; set; }
    }
}
