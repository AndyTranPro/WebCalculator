using System;
using backend.Interfaces;

namespace backend.Models;

public class DivisionOperation : ICalculatorOperation
{
    public double Execute(List<int> values) => values.Aggregate((x, y) => x / y);
}
