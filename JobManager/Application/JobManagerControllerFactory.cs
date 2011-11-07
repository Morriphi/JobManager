using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

namespace JobManager.Application
{
    public class JobManagerControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, System.Type controllerType)
        {
            return ObjectFactory.GetInstance(controllerType) as IController;
        }
    }
}