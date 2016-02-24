﻿namespace MvcTemplate.Web.Controllers.Tests
{
    using Data.Models;
    using Infrastructure.Mapping;
    using Moq;
    using NUnit.Framework;
    using Services.Data;
    using TestStack.FluentMVCTesting;
    using ViewModels.Home;

    [TestFixture]
    public class JokesControllerTests
    {
        [Test]
        public void ByIdShouldWorkCorrect()
        {
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(JokesController).Assembly);

            const string JokeContent = "SomeContent";

            var jokesServiceMock = new Mock<IJokesService>();
            jokesServiceMock
                .Setup(x => x.GetById(It.IsAny<string>()))
                .Returns(new Joke() { Content = JokeContent, Category = new JokeCategory { Name = "joker" } });
            var controller = new JokesController(jokesServiceMock.Object);
            controller
                .WithCallTo(x => x.ById("asdfgh"))
                .ShouldRenderView("ById")
                .WithModel<JokeViewModel>(viewModel => { Assert.AreEqual(JokeContent, viewModel.Content); }).AndNoModelErrors();
        }
    }
}