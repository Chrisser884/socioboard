using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Socioboard.App_Start
{
    public class CustomAuthorize : AuthorizeAttribute
    {
      
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
<<<<<<< HEAD
            if (httpContext.Session["User"] != null || httpContext.Session["fblogin"] != null) 
=======
            if (httpContext.Session["User"] != null) 
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            {
                authorize = true;
            }
            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }  
    }
}