using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CiTest.Web.Startup))]
namespace CiTest.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
