using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCustomerApp.Startup))]
namespace MVCCustomerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
