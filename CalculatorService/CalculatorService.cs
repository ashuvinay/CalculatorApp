namespace CalculatorLibrary
{
    public class CalculatorService
    {
        private readonly Dictionary<string, IOperation> _operations;

        public CalculatorService()
        {
            _operations = new Dictionary<string, IOperation>
            {
                { "+", new Addition() },
                { "-", new Subtraction() },
                { "×", new Multiplication() },
                { "÷", new Division() }
            };
        }

        public decimal ExecuteOperation(string operation, decimal a, decimal b)
        {
            if (_operations.TryGetValue(operation, out IOperation? op))
            {
                return op.Execute(a, b);
            }
            throw new InvalidOperationException("Invalid operation");
        }
    }
}
