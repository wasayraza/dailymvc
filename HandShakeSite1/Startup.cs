using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandShakeSite1.Startup))]
namespace HandShakeSite1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
