using BidCalculatorRest.Models;
using BidCalculatorRest.Services.Facade;
using Microsoft.AspNetCore.Mvc;

namespace BidCalculatorRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BidCalculatorController : ControllerBase
    {

        private readonly ILogger<BidCalculatorController> _logger;

        public BidCalculatorController(ILogger<BidCalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Calculate bid")]
        public Calculation CalculateBid(string type, int price)
        {
            Calculation calculation = new Calculation(type, price);
            CalculateFacade calculateFacade = new CalculateFacade();
            calculation = calculateFacade.calculate(calculation);
            return calculation;
        }
    }
}