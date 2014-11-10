using Microsoft.Owin;
using Owin;
using SoftIt.JQueryDataTables.Demo;

[assembly: OwinStartup(typeof(Startup))]
namespace SoftIt.JQueryDataTables.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
