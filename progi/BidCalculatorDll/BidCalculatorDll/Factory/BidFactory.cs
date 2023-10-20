using BidCalculation.Services;

namespace BidCalculation.Factory
{
    public class BidFactory
    {
        public ICalculateService createFactory(string type) {
            if (type.Equals("Common"))
            {
                return new CommonComputes();
            } else
            {
                return new LuxuryCompute();
            }
        }
    }
}
