using backend.Interfaces;
using backend.Models;
using backend.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/calculator")]
[ApiController]
public class CalculatorController : ControllerBase
{
    private readonly ICalculationService _calculationService;
    public CalculatorController(ICalculationService calculationService)
    {
        _calculationService = calculationService;
    }

    [HttpPost]
    public IActionResult Calculate([FromBody] CalculationRequest request)
    {
        // check if the maths object is null
        if (request == null)
        {
            return BadRequest("Invalid input");
        }

        // Process each operation
        var results = request.Maths.Operations.Select(operation =>
        {
            return _calculationService.Calculate(operation.ID, operation.Value);
        });
        return Ok(new { Results = results });
    }
}
