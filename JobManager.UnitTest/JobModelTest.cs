using JobManager.Interface;
using JobManager.Models;
using NUnit.Framework;

namespace JobManager.UnitTest
{
    public class JobModelTest
    {
        [Test]
        public void GetJobId()
        {
            var model = new JobModel(new Job(123456));

            Assert.That(model.JobId(), Is.EqualTo(123456));
        }
    }
}
