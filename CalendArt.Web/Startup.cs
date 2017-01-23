using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalendArt.Web.Startup))]
namespace CalendArt.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
