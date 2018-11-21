using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chart_Project.Startup))]
namespace Chart_Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
