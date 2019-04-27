using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee_Mgmt_System.Startup))]
namespace Employee_Mgmt_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
