using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlfaOmega.Startup))]
namespace AlfaOmega
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
