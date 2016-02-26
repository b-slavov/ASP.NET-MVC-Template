namespace MvcTemplate.Web.Routes.Tests
{
    using System.Web.Routing;
    using Controllers;
    using MvcRouteTester;
    using NUnit.Framework;

    [TestFixture]
    public class JokesRouteTests
    {
        [Test]
        public void TestRouteById()
        {
            const string url = "/Joke/NTIyNC4xMjMxMjMxMzEyMw==";
            var routeCollection = new RouteCollection();
            RouteConfig.RegisterRoutes(routeCollection);
            routeCollection.ShouldMap(url).To<JokesController>(c => c.ById("NTIyNC4xMjMxMjMxMzEyMw=="));
        }
    }
}