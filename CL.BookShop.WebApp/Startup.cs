using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CL.BookShop.WebApp.Startup))]
namespace CL.BookShop.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
