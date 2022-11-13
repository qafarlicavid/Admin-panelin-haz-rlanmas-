using Microsoft.AspNetCore.Mvc;

namespace Admin_panelin_hazırlanması.Authentication.Controllers
{
    public class Error404altController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
