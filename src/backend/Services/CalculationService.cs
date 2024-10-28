using System;
using backend.Interfaces;
using backend.Models;

namespace backend.Services;

public class CalculationService: ICalculationService
{
    private readonly Dictionary<string, ICalculatorOperation> _operations = new()
    {
        { "Plus", new AdditionOperation() },
        { "Minus", new SubstractionOperation() },
        { "Multiplication", new MultiplicationOperation() },
        { "Division", new DivisionOperation() }
    };

    public double Calculate(string operationId, List<int> values)
    {
        if (values == null)
        {
            throw new InvalidOperationException("Operation values are required");
        }
        if (_operations.TryGetValue(operationId, out var calculatorOperation))
        {
            return calculatorOperation.Execute(values);
        }
        throw new InvalidOperationException("Operation not supported");
    }
}
