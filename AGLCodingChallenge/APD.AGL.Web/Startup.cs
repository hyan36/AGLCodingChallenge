using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APD.AGL.Web.Startup))]
namespace APD.AGL.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
