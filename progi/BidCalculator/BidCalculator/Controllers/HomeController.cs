using BidCalculation.Models;
using BidCalculation.Services.Facade;
using BidCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BidCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculate _calculate;

        public HomeController(ILogger<HomeController> logger, ICalculate calculate)
        {
            _logger = logger;
            _calculate = calculate;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("id, type, price")] Calculation calculation)
        {
            List<Calculation> calculations = _calculate.calculate(calculation);

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index", calculations);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}