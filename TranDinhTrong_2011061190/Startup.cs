using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranDinhTrong_2011061190.Startup))]
namespace TranDinhTrong_2011061190
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
