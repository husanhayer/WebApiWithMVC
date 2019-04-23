using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPro.Startup))]
namespace MVCPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
