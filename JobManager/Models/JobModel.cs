using JobManager.Interface;

namespace JobManager.Models
{
    public class JobModel
    {
        private readonly Job _job;

        public JobModel(Job job)
        {
            _job = job;
        }

        public int JobId()
        {
            return _job.Id;
        }
    }
}