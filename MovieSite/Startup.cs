using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieSite.Startup))]
namespace MovieSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
