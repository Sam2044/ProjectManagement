using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectMgt.Startup))]
namespace ProjectMgt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
