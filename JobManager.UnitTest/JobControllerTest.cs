using System.Web.Mvc;
using JobManager.Controllers;
using JobManager.Models;
using JobManager.UnitTest.Doubles;
using NUnit.Framework;

namespace JobManager.UnitTest
{
    public class JobControllerTest
    {
        private JobController _controller;
        private ActionResult _result;
        private FakeJobService _fakeJobService;

        [SetUp]
        public void BeforeEachTest()
        {
            _fakeJobService = new FakeJobService();
            _controller = new JobController(_fakeJobService);   
        }

        [Test]
        public void ShouldGoToJobListPage()
        {
            _result = _controller.List();

            Assert.That(_result, Is.InstanceOf<ViewResult>());
            Assert.That(ViewResult().ViewName, Is.EqualTo("Job"));
        }

        [Test]
        public void ShouldGoToJobDetailsPage()
        {
            _result = _controller.Details(123456);

            Assert.That(_result, Is.InstanceOf<ViewResult>());
            Assert.That(ViewResult().ViewName, Is.EqualTo("Details"));
            Assert.That(ViewResult().ViewData.Model, Is.InstanceOf<JobModel>());
            Assert.That(_fakeJobService.CalledWithJobId, Is.EqualTo(123456));
            Assert.That(((JobModel)ViewResult().ViewData.Model).JobId(), Is.EqualTo(123456));
        }

        private ViewResult ViewResult()
        {
            return ((ViewResult)_result);
        }
    }
}
