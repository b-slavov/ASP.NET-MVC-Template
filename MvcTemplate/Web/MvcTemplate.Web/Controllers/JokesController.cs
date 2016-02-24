namespace MvcTemplate.Web.Controllers
{
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Home;

    public class JokesController : BaseController
    {
        private IJokesService jokes;

        public JokesController(IJokesService jokes)
        {
            this.jokes = jokes;
        }

        public ActionResult ById(string id)
        {
            var joke = this.jokes.GetById(id);
            var viewModel = AutoMapperConfig.Configuration.CreateMapper().Map<JokeViewModel>(joke);

            return this.View(viewModel);
        }
    }
}