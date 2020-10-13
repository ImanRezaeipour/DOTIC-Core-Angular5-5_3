using Microsoft.AspNetCore.Antiforgery;

namespace PTC.DOTIC.Web.Controllers
{
    public class AntiForgeryController : DOTICControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
