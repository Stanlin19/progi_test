using BidCalculation.Models;

namespace BidCalculation.Services
{
    public interface ICalculateService
    {
        Calculation calculate(Calculation calculation);
    }
}
