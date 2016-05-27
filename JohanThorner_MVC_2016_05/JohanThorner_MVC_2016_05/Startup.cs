using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JohanThorner_MVC_2016_05.Startup))]
namespace JohanThorner_MVC_2016_05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
