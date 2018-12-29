using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMC.Startup))]
namespace WebAppMC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
