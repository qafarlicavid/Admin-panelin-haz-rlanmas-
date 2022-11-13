using Microsoft.AspNetCore.Mvc;

namespace Admin_panelin_hazırlanması.Authentication.Controllers
{
    public class error500Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
