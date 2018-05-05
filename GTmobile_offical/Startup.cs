using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GTmobile_offical.Startup))]
namespace GTmobile_offical
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
