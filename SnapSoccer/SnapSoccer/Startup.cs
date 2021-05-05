using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SnapSoccer.Startup))]
namespace SnapSoccer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
