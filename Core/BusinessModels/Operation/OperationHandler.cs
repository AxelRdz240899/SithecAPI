﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessModels.Operation
{
    public class OperationHandler
    {
        private readonly Dictionary<char, Type> availableOperations = new Dictionary<char, Type>();

        // Así cumple con el principio de Open Closed de SOLID, podemos agregar n operadores y funcionará igual !!
        public OperationHandler()
        {
            // Para forzar que se cargue el assembly de la biblioteca core
            var coreAssembly = typeof(IOperation).Assembly;

            var operationTypes = coreAssembly.GetTypes().Where(t => typeof(IOperation).IsAssignableFrom(t) && !t.IsInterface).ToList();

            foreach (var operationType in operationTypes)
            {
                var operationAttribute = operationType.GetCustomAttribute<OperationSymbol>();
                if (operationAttribute != null)
                {
                    var operation = Activator.CreateInstance(operationType) as IOperation;
                    availableOperations[operationAttribute.SymbolValue] = operationType;
                }
            }
        }

        public double MakeOperation(double num1, double num2, char operationSymbol)
        {
            if (availableOperations.TryGetValue(operationSymbol, out Type operationType))
            {
                var operatorInstance = Activator.CreateInstance(operationType) as IOperation;
                return operatorInstance.ExecuteOperation(num1, num2);
            }

            throw new NotImplementedException("This operator is not implemented");
        }
    }
}
