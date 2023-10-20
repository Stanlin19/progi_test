using BidCalculatorRest.Models;
using BidCalculatorRest.Services.Facade;

namespace BidCalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBidCalculatorCommonType()
        {
            string type = "Common";
            int price = 398;
            Calculation calculation = new Calculation(type, price);
            CalculateFacade calculateFacade = new CalculateFacade();
            calculation = calculateFacade.calculate(calculation);
            Assert.True(550.76 == calculation.total);
        }

        [Fact]
        public void TestBidCalculatorLuxuryType()
        {
            string type = "Luxury";
            int price = 1800;
            Calculation calculation = new Calculation(type, price);
            CalculateFacade calculateFacade = new CalculateFacade();
            calculation = calculateFacade.calculate(calculation);
            Assert.True(2167.00 == calculation.total);
        }
    }
}