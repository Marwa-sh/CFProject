using System.Web.Mvc;

namespace Portal.Areas.DebtsCalculator
{
    public class DebtsCalculatorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DebtsCalculator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DebtsCalculator_default",
                "DebtsCalculator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}