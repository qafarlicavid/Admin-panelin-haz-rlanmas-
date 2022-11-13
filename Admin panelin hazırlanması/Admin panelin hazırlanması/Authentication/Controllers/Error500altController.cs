using Microsoft.AspNetCore.Mvc;

namespace Admin_panelin_hazırlanması.Authentication.Controllers
{
    public class Error500altController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
