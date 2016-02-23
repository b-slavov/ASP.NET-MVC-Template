namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;

    public class CategoriesService : ICategoriesService
    {
        private IDbRepository<JokeCategory> categories;

        public CategoriesService(IDbRepository<JokeCategory> categories)
        {
            this.categories = categories;
        }

        public IQueryable<JokeCategory> GetAll()
        {
            return this.categories.All().OrderBy(x => x.Name);
        }
    }
}