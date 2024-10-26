using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using questionnaire1.Models;

namespace questionnaire1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IList<Question> _questions;

        public HomeController(IList<Question> questions)
        {
            _questions = questions;
        }

        public IActionResult Index()
        {
            return View(_questions);
        }
    }
}
