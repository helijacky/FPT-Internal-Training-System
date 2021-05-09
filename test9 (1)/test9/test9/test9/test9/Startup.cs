using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test9.Startup))]
namespace test9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
