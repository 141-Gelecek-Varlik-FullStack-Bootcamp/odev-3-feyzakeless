using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Pharmacy.Extension;
using System;

namespace Pharmacy.API.Controllers
{
    public class LoginFilter : Attribute, IActionFilter
    {
        /// <summary>
        /// UserType1 = Hasta,
        /// UserType2 = Eczacı,
        /// UserType3 = Doktor
        /// </summary>
        string userType = ExtensionFile.GetEnum(Pharmacy.Extension.Enum.UserType3); //Authorized User
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (userType == "Hasta")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Medicine", Action = "GetMedicines" }));
            }
            else if (userType == "Eczacı")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Prescription", Action = "GetPrescription" }));
            }
            else if (userType == "Doktor")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "User", Action = "GetPatients" }));
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
