using BidCalculation.Factory;
using BidCalculation.Models;

namespace BidCalculation.Services.Facade
{
    public class CalculateFacade : ICalculate
    {

        private static List<Calculation> calculations = new List<Calculation>();

        public List<Calculation> calculate(Calculation calculation)
        {
            BidFactory bidFactory = new BidFactory();
            ICalculateService calculate = bidFactory.createFactory(calculation.type);
            if (calculation.id <= 0)
            {
                calculation.id = calculations.Count+1;
            }
            calculation = calculate.calculate(calculation);
            calculations.Add(calculation);
            return calculations;
        }
    }
}
