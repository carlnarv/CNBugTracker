using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CNBugTracker.Startup))]
namespace CNBugTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
