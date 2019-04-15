using Microsoft.AspNetCore.Antiforgery;
using Study.Controllers;

namespace Study.Web.Host.Controllers
{
    public class AntiForgeryController : StudyControllerBase
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
