using JobManager.Interface;

namespace JobManager.Service
{
    public class JobService : IJobService
    {
        public Job GetJob(int id)
        {
            return new Job(id);
        }
    }
}