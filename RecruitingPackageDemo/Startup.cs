using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecruitingPackageDemo.Startup))]
namespace RecruitingPackageDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
