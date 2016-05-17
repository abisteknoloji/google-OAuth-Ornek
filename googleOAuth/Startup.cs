using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(googleOAuth.Startup))]
namespace googleOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
