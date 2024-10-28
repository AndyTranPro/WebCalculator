using System;
using backend.Models;

namespace backend.Interfaces;

public interface ICalculationService
{
    public double Calculate(string operationId, List<int> values);
}
