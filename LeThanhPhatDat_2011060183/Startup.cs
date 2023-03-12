using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeThanhPhatDat_2011060183.Startup))]
namespace LeThanhPhatDat_2011060183
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
