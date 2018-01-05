using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(childDomain.Startup))]
namespace childDomain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
