using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicineShop.Startup))]
namespace MedicineShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
