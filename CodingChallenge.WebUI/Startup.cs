using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodingChallenge.WebUI.Startup))]
namespace CodingChallenge.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
