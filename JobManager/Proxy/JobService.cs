using System.ServiceModel;
using System.ServiceModel.Channels;
using JobManager.Interface;

namespace JobManager.Proxy
{
    public class JobService : ClientBase<IJobService>, IJobService
    {
        public JobService(Binding binding, EndpointAddress endpointAddress)
            :base(binding, endpointAddress)
        {
            
        }

        public Job GetJob(int id)
        {
            return Channel.GetJob(id);
        }
    }
}