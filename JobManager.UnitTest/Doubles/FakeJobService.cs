using JobManager.Interface;

namespace JobManager.UnitTest.Doubles
{
    public class FakeJobService : IJobService
    {
        public int CalledWithJobId;
        public Job GetJob(int id)
        {
            CalledWithJobId = id;
            return new Job(id);
        }
    }
}