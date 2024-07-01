
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using money_manager.Models;
namespace money_manager.Controllers
{
    public class ExpenseController :Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


    }
}
