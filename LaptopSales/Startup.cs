using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaptopSales.Startup))]
namespace LaptopSales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
