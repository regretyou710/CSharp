using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS_demo46_1.Startup))]
namespace CS_demo46_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
