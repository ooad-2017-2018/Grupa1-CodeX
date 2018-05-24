using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AvMauASP.Startup))]
namespace AvMauASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
