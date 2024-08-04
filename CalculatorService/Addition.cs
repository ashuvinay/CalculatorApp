using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class Addition : IOperation
    {
        public decimal Execute(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
