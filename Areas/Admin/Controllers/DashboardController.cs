using Microsoft.AspNetCore.Mvc;

namespace HexaReportApp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/Dashboard")]
    public class DashboardController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
