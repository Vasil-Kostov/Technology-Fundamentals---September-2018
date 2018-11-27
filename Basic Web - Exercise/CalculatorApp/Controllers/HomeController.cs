using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            if (calculator.Operator == "/" && calculator.RightOperand == 0)
            {
                TempData["ErrorMessage"] = "Can not divide by zero!";
            }
            else
            {
                calculator.CalculateResult();

                Data.PreviousCalculations.Insert(0, calculator); //LIFO
            }

            return RedirectToAction("Index", calculator);
        }

        [HttpGet]
        public IActionResult History()
        {
            return View(Data.PreviousCalculations);
        }

    }
}
