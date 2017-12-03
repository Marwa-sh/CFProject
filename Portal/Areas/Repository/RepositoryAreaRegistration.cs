using System.Web.Mvc;

namespace Portal.Areas.Repository
{
    public class RepositoryAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Repository";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Repository_default",
                "Repository/{controller}/{action}/{id}",                 
                new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}