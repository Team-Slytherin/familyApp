using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyApp.Startup))]
namespace FamilyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
