using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsEF.Startup))]
namespace WebFormsEF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
