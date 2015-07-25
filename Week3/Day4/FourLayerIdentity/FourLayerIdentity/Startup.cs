using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FourLayerIdentity.Startup))]
namespace FourLayerIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
