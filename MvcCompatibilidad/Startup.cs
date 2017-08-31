using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCompatibilidad.Startup))]
namespace MvcCompatibilidad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
