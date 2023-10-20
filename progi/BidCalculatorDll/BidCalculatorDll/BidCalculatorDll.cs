using BidCalculation.Models;
using BidCalculation.Services.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidCalculatorDll
{
    public class BidCalculatorDll
    {
        public static Calculation calculate(Calculation calculation)
        {
            CalculateFacade calculateFacade = new CalculateFacade();
            calculation = calculateFacade.calculate(calculation);
            return calculation;
        }
    }
}
