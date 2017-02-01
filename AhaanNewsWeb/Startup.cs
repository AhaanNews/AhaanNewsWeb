using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AhaanNewsWeb.Startup))]
namespace AhaanNewsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
