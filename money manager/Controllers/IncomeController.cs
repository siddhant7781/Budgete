using Microsoft.AspNetCore.Mvc;

namespace money_manager.Controllers
{
    public class IncomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
