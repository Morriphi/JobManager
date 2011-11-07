using System.ServiceModel;
using JobManager.Interface;
using JobManager.Proxy;
using StructureMap;

namespace JobManager.Application
{
    public class IoCWireup
    {
        public static void Initialize(IInitializationExpression obj)
        {
            obj.For<IJobService>().Use(JobServiceProxyBuilder.Build);
        }
    }

    public static class JobServiceProxyBuilder
    {
        public static JobService Build()
        {
            return new JobService(new NetTcpContextBinding(SecurityMode.None),
                new EndpointAddress("net.tcp://localhost:9001/JobService"));
        }
    }
}