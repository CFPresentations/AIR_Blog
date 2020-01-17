using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIR_Blog.Startup))]
namespace AIR_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
