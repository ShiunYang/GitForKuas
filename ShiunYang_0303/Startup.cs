using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShiunYang_0303.Startup))]
namespace ShiunYang_0303
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
