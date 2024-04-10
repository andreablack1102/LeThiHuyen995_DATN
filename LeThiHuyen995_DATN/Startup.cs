using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeThiHuyen995_DATN.Startup))]
namespace LeThiHuyen995_DATN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
