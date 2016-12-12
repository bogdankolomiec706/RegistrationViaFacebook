using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RadaCode.Startup))]
namespace RadaCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
