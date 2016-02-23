namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using MvcTemplate.Data.Models;

    public interface ICategoriesService
    {
        IQueryable<JokeCategory> GetAll();
    }
}