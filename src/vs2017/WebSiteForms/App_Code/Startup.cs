using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteForms.Startup))]

namespace WebSiteForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}