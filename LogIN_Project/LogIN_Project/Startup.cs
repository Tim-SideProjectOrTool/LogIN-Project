using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogIN_Project.Startup))]
namespace LogIN_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
