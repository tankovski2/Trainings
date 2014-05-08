using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlimpseDemo.Model_Binders
{
    public class SpecialBinder : IModelBinder
    {    
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var theDate = controllerContext.RequestContext.HttpContext.Request.QueryString["datetime"];
            DateTime convertedDateTime;
            DateTime.TryParse(theDate, CultureInfo.GetCultureInfo("en-GB"), DateTimeStyles.None, out convertedDateTime);
            return convertedDateTime;
        }
    }
}