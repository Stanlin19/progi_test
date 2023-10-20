using BidCalculatorRest.Models;

namespace BidCalculatorRest.Services
{
    public class LuxuryCompute : ICalculateService
    {
        public Calculation calculate(Calculation calculation)
        {
            calculation.basic = calculation.price * 0.10;
            calculation.basic = calculation.basic < 25 ? 25 : calculation.basic > 200 ? calculation.basic = 200 : calculation.basic;
            calculation.special = calculation.price * 0.04;
            calculation.setAssociation();
            calculation.total = calculation.price + calculation.basic + calculation.storage +
                calculation.association + calculation.special;

            return calculation;
        }
    }
}
