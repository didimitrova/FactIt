using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FactItSystem.Web.Startup))]
namespace FactItSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
