// Uncomment this class to provide custom runtime policy for Glimpse

using Glimpse.AspNet.Extensions;
using Glimpse.Core.Extensibility;

namespace GlimpseDemo
{
    public class GlimpseSecurityPolicy:IRuntimePolicy
    {
        public RuntimePolicy Execute(IRuntimePolicyContext policyContext)
        {
            // You can perform a check like the one below to control Glimpse's permissions within your application.
			// More information about RuntimePolicies can be found at http://getglimpse.com/Help/Custom-Runtime-Policy
			// var httpContext = policyContext.GetHttpContext();
            // if (!httpContext.User.IsInRole("Administrator"))
			// {
            //     return RuntimePolicy.Off;
			// }

            if (policyContext.GetHttpContext().Request.Browser.IsMobileDevice)
                return RuntimePolicy.PersistResults;

            return RuntimePolicy.On;
        }

        public RuntimeEvent ExecuteOn
        {
            get { return RuntimeEvent.EndRequest; }
        }
    }
}