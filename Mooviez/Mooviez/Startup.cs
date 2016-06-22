using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mooviez.Startup))]
namespace Mooviez
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
