namespace MvcTemplate.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Data.Common;
    using Data.Models;
    using Infrastructure.Mapping;
    using ViewModels.Home;

    public class HomeController : Controller
    {
        private IDbRepository<Joke> jokes;

        private IDbRepository<JokeCategory> jokeCategories;

        public HomeController(IDbRepository<Joke> jokes, IDbRepository<JokeCategory> jokeCategories)
        {
            this.jokes = jokes;
            this.jokeCategories = jokeCategories;
        }

        public ActionResult Index()
        {
            var jokes = this.jokes.All().OrderBy(x => Guid.NewGuid()).Take(3).To<JokeViewModel>().ToList();
            return this.View(jokes);
        }
    }
}