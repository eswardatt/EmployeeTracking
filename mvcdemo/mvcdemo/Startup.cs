using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcdemo.Startup))]
namespace mvcdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
