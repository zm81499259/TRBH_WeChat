using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeChat.Application.Startup))]
namespace WeChat.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
