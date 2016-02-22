namespace MvcTemplate.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Data;

    public class HomeController : Controller
    {
        // private IDbRepository<>

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var usersCount = db.Users.Count();
            return this.View();
        }
    }
}