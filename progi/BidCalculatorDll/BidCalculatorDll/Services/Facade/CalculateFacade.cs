using BidCalculation.Factory;
using BidCalculation.Models;

namespace BidCalculation.Services.Facade
{
    public class CalculateFacade
    {

        public Calculation calculate(Calculation calculation)
        {
            BidFactory bidFactory = new BidFactory();
            ICalculateService calculate = bidFactory.createFactory(calculation.type);

            calculation = calculate.calculate(calculation);

            return calculation;
        }
    }
}
