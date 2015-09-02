using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day12a.Startup))]
namespace Day12a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
