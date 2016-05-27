using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testAplication.Startup))]
namespace testAplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
