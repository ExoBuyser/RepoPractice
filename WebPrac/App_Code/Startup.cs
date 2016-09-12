using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPrac.Startup))]
namespace WebPrac
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
