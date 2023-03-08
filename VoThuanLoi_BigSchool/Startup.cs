using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoThuanLoi_BigSchool.Startup))]
namespace VoThuanLoi_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
