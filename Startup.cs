using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentricTeam9MIS4200.Startup))]
namespace CentricTeam9MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
