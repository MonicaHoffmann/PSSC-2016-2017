using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(University_App.Startup))]
namespace University_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
