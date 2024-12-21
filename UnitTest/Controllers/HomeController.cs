using Microsoft.AspNetCore.Mvc;

namespace UnitTestingWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WhatIsUnitTesting()
        {
            return View();
        }

        public IActionResult HowToWriteTests()
        {
            return View();
        }

        public IActionResult BenefitsChallenges()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitQuiz(string answer1, string answer2, string answer3)
        {
            ViewBag.Score = 0;

            if (answer1 == "CorrectAnswer1") ViewBag.Score++;
            if (answer2 == "CorrectAnswer2") ViewBag.Score++;
            if (answer3 == "CorrectAnswer3") ViewBag.Score++;

            return View("QuizResult");
        }
    }
}
