using Microsoft.AspNetCore.Mvc;

namespace SmartQuizAPI.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
