using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comunidad.Startup))]
namespace comunidad
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
