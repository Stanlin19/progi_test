using BidCalculatorRest.Models;

namespace BidCalculatorRest.Services
{
    public interface ICalculateService
    {
        Calculation calculate(Calculation calculation);
    }
}
