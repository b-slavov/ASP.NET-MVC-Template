namespace MvcTemplate.Web.ViewModels.Home
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class JokeViewModel : IMapFrom<Joke>, IMapTo<Joke>
    {
        public string Content { get; set; }
    }
}