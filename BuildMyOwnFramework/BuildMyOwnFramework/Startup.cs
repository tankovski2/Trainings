using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildMyOwnFramework.Startup))]
namespace BuildMyOwnFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
