using System.Web;
using StructureMap;

namespace BuildMyOwnFramework.Infrastructure
{
    public static class ContainerPerRequestExtensions
    {
        public static IContainer GetContainer(this HttpContextBase context)
        {
            return (IContainer)HttpContext.Current.Items["_Container"]
                ?? ObjectFactory.Container;
        }
    }
}