using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalendArt.Startup))]
namespace CalendArt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
