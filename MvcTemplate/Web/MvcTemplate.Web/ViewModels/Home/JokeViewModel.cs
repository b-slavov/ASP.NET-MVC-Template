namespace MvcTemplate.Web.ViewModels.Home
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class JokeViewModel : IMapFrom<Joke>, IHaveCustomMappings
    {
        public string Content { get; set; }

        public string Category { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Joke, JokeViewModel>().ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}