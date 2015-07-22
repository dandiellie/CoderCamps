using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNetIdentityDemo.Startup))]
namespace ASPNetIdentityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
