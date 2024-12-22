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

        private static readonly Dictionary<int, string> CorrectAnswers = new Dictionary<int, string>
    {
        { 1, "B" },
        { 2, "C" },
        { 3, "A" },
        { 4, "B" },
        { 5, "C" },
        { 6, "C" },
        { 7, "D" },
        { 8, "B" },
        { 9, "B" },
        { 10, "B" },
        { 11, "B" },
        { 12, "B" },
        { 13, "B" },
        { 14, "B" },
        { 15, "B" },
        { 16, "B" },
        { 17, "C" },
        { 18, "B" },
        { 19, "B" },
        { 20, "C" }
    };

        [HttpGet]
        public ActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quiz(FormCollection form)
        {
            int score = 0;

            // Loop through all the questions
            for (int i = 1; i <= 20; i++)
            {
                // Get the user's answer
                var userAnswer = form["question" + i];

                // Compare user's answer with the correct answer
                if (userAnswer == CorrectAnswers[i])
                {
                    score++;
                }
            }

            // Pass the score to the view
            ViewBag.Score = score;
            return View();
        }
    }
}
