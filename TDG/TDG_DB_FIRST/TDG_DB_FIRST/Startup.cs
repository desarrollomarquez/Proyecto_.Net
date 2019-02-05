using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDG_DB_FIRST.Startup))]
namespace TDG_DB_FIRST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
