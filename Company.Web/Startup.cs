using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Company.Web.Startup))]
namespace Company.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
