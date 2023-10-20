using BidCalculatorRest.Services;

namespace BidCalculatorRest.Factory
{
    public class BidFactory
    {
        public ICalculateService createFactory(string type)
        {
            if (type.Equals("Common"))
            {
                return new CommonCompute();
            }
            else
            {
                return new LuxuryCompute();
            }
        }
    }
}
