using BidCalculation.Models;

namespace BidCalculation.Services.Facade
{
    public interface ICalculate
    {
        List<Calculation> calculate(Calculation calculation);
    }
}
