using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cookie.Startup))]
namespace cookie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
