using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Djur_MVC.Startup))]
namespace Djur_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
