using System;
using System.ServiceModel;
using JobManager.Interface;

namespace JobManager.Service
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(JobService)))
            {
                host.AddServiceEndpoint(typeof(IJobService), new NetTcpContextBinding(SecurityMode.None), 
                    "net.tcp://localhost:9001/JobService");

                host.Open();

                Console.ReadLine();
            }
        }
    }
}
