using System.ServiceModel;

namespace JobManager.Interface
{
    [ServiceContract]
    public interface IJobService
    {
        [OperationContract]
        Job GetJob(int id);
    }
}