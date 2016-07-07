using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubAddNewProject.Startup))]
namespace GitHubAddNewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
