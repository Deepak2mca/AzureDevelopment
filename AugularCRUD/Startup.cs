using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AugularCRUD.Startup))]
namespace AugularCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
