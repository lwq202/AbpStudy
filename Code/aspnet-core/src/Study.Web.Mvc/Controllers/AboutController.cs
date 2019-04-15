using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Study.Controllers;

namespace Study.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : StudyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
