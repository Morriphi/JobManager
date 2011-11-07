using System.Web.Routing;
using JobManager.UnitTest.Doubles;
using NUnit.Framework;

namespace JobManager.UnitTest
{
    public class RouteTest
    {
        private RouteCollection _routes;
        private RouteData _routeData;

        [SetUp]
        public void BeforeEachTest()
        {
            _routes = new RouteCollection();
            MvcApplication.RegisterRoutes(_routes);   
        }

        [Test]
        public void ShouldIgnoreRequestForFavIcon()
        {
            NavigateToRoute("GET", "~/favicon.ico");

            Assert.That(RouteValue("controller"), Is.Null);
        }

        [Test]
        public void ShouldNavigateToJobList()
        {
            NavigateToRoute("GET", @"~/Job");

            Assert.That(RouteValue("controller"), Is.EqualTo("Job"));
            Assert.That(RouteValue("action"), Is.EqualTo("List"));
        }

        [Test]
        public void ShouldNavigateToJobDetailsPage()
        {
            NavigateToRoute("GET", @"~/Job/Details/123456");

            Assert.That(RouteValue("controller"), Is.EqualTo("Job"));
            Assert.That(RouteValue("action"), Is.EqualTo("Details"));
            Assert.That(RouteValue("id"), Is.EqualTo("123456"));
        }

        private object RouteValue(string controller)
        {
            return _routeData.Values[controller];
        }

        private void NavigateToRoute(string method, string relativeUrl)
        {
            _routeData = _routes.GetRouteData(new FakeHttpContext(method, relativeUrl));
        }
    }
}
