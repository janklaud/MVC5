using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5.Startup))]
namespace mvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
