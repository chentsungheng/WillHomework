using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WillMvcHomework1.Startup))]
namespace WillMvcHomework1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
