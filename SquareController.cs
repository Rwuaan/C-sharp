using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRootWeb.Controllers
{
    public class SquareController : Controller
    {
        [HttpGet]
        public ActionResult CompareSquareRoot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CompareSquareRoot(string firstNumber, string secondNumber)
        {
            int numberOne = int.Parse(firstNumber);
            int numberTwo = int.Parse(secondNumber);


            ViewBag.firstNumber = numberOne;
            ViewBag.secondNumber = numberTwo;

            int SquareRootnumberOne = (int)Math.Sqrt(numberOne);
            int SquareRootnumberTwo = (int)Math.Sqrt(numberTwo);

            ViewBag.SRN1 =SquareRootnumberOne;
            ViewBag.SRN2 = SquareRootnumberTwo;

            return View();
        }

    }
}