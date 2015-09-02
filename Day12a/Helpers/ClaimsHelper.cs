using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
namespace Day12a.Helpers
{
    public static class ClaimsHelper
    {
        public static bool IsAdmin()
        {
            var user = HttpContext.Current.User.Identity as ClaimsIdentity;
            return user.HasClaim("CanEditProducts", "true");
        }
    }
}