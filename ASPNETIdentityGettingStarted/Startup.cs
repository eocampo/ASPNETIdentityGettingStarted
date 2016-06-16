using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETIdentityGettingStarted.Startup))]
namespace ASPNETIdentityGettingStarted
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
