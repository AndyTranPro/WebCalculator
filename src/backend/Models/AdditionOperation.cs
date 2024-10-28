using System;
using backend.Interfaces;

namespace backend.Models;

public class AdditionOperation : ICalculatorOperation
{
    public double Execute(List<int> values) => values.Sum();
}
