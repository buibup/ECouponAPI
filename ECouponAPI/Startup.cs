using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ECouponAPI.Startup))]
namespace ECouponAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}