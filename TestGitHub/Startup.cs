using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitHub.Startup))]
namespace TestGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
