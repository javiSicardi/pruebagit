using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web.web.Startup))]
namespace web.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
