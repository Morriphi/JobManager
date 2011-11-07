using System.Runtime.Serialization;

namespace JobManager.Interface
{
    [DataContract]
    public class Job
    {
        [DataMember]
        public int Id { get; set; }

        public Job(int id)
        {
            Id = id;
        }
    }
}