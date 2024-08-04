using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public interface IOperation
    {
        decimal Execute(decimal a, decimal b);
    }
}
