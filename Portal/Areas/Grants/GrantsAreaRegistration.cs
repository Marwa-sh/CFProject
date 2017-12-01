using System.Web.Mvc;

namespace Portal.Areas.Grants
{
    public class GrantsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Grants";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Grants_default",
                "Grants/{controller}/{action}/{id}",
                new {area= "Grants", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}