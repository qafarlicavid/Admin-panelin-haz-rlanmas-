using Microsoft.AspNetCore.Mvc;

namespace Admin_panelin_hazırlanması.Authentication.Controllers
{
    public class Error404Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
