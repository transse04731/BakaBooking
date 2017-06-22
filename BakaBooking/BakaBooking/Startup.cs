using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BakaBooking.Startup))]
namespace BakaBooking
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
