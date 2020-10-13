using Microsoft.AspNetCore.Mvc;
using PTC.DOTIC.Web.Controllers;

namespace PTC.DOTIC.Web.Public.Controllers
{
    public class AboutController : DOTICControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}