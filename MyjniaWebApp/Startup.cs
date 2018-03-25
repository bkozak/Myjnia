using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyjniaWebApp.Startup))]
namespace MyjniaWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
