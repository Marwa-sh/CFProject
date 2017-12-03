using System.Web.Mvc;

namespace Portal.Areas.Loans
{
    public class LoansAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Loans";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Loans_default",
                "Loans/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}