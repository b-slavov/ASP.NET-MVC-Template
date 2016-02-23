namespace MvcTemplate.Web.ViewModels.Home
{
    using Infrastructure.Mapping;
    using MvcTemplate.Data.Models;

    public class JokeCategoryViewModel : IMapFrom<JokeCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}