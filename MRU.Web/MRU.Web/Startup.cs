using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MRU.Web.Startup))]
namespace MRU.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
