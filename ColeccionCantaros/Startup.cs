using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColeccionCantaros.Startup))]
namespace ColeccionCantaros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
