using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppGitHub.Startup))]
namespace WebAppGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
