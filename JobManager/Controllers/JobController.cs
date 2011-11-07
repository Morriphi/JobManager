using System.Web.Mvc;
using JobManager.Interface;
using JobManager.Models;

namespace JobManager.Controllers
{
    public class JobController : Controller
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        public ActionResult List()
        {
            return View("Job");
        }

        public ActionResult Details(int id)
        {
            ViewData.Model = new JobModel(_jobService.GetJob(id));

            return View("Details");
        }
    }
}