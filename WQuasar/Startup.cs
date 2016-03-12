using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WQuasar.Startup))]
namespace WQuasar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
