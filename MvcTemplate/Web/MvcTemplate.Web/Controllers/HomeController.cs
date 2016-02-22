namespace MvcTemplate.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private IService service;

        public HomeController(IService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            this.service.Work();
            return this.View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}