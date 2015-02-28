using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wedding.Startup))]
namespace wedding
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
