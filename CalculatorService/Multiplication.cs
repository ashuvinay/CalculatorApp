using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class Multiplication : IOperation
    {
        public decimal Execute(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
