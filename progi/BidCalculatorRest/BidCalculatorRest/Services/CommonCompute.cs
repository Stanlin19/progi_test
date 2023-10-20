using BidCalculatorRest.Models;

namespace BidCalculatorRest.Services
{
    public class CommonCompute : ICalculateService
    {
        public Calculation calculate(Calculation calculation)
        {
            calculation.basic = calculation.price * 0.10;
            calculation.basic = calculation.basic < 10 ? 10 : calculation.basic > 50 ? calculation.basic = 50 : calculation.basic;
            calculation.special = calculation.price * 0.02;
            calculation.setAssociation();
            calculation.total = calculation.price + calculation.basic + calculation.storage +
                calculation.association + calculation.special;

            return calculation;
        }
    }
}
