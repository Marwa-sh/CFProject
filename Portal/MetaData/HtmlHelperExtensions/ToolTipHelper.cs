using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Portal
{
    public static class ToolTipHelper
    {
        public static MvcHtmlString ToolTipMessageFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            string tooltopMessage = string.Empty;
            var exp = (MemberExpression)expression.Body;
            Type t = exp.Expression.Type;
            var l = t.GetCustomAttributes(typeof(MetadataTypeAttribute), true);
            if (l.Length == 0) return MvcHtmlString.Empty;
            MetadataTypeAttribute a = l[0] as MetadataTypeAttribute;
            if (a == null) return MvcHtmlString.Empty;
            var p = a.MetadataClassType.GetProperty(exp.Member.Name).GetCustomAttributes(false);
            foreach (Attribute attribute in p)
            {
                if (typeof(Cf.Data.TooltipAttribute) == attribute.GetType())
                {
                    var tooltipHelper = attribute as Cf.Data.TooltipAttribute;
                    tooltopMessage = tooltipHelper.LocalizedDescription;
                    return MvcHtmlString.Create(tooltopMessage);
                }
                if (typeof(RequiredAttribute) == attribute.GetType())
                {
                    var tooltipHelper = attribute as RequiredAttribute;
                    if (tooltopMessage == string.Empty)
                    {
                        tooltopMessage = tooltipHelper.ErrorMessage;
                    }
                }
            }
            return MvcHtmlString.Create(tooltopMessage);
        }
    }
}