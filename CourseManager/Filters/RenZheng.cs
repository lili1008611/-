using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;
using CourseManager.Models.ValidatableObjects;

namespace CourseManager.Filters
{
    public class RenZheng : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if(filterContext.HttpContext.Session !=null)
            {
                var user = filterContext.HttpContext.Session["user"]?.ToString();
                if (!string.IsNullOrWhiteSpace(user))
                {
                    return;
                }
                var cookie = filterContext.HttpContext.Response.Cookies?["user"];
                if (string.IsNullOrEmpty(cookie?.Value))
                {
                    throw new UnauthorizedException();
                }
                var content = cookie?.Value.DecrypyqueryString();
                CourseManagerEntities db = new CourseManagerEntities();
                if (!db.Users.Any(u => u.Account == content))
                {
                    throw new UnauthorizedException();
                }
            }
        }
    }
}