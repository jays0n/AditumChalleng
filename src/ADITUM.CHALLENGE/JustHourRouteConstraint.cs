using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADITUM.CHALLENGE
{
    public class JustHourRouteConstraint : IRouteConstraint
    {
        private static readonly Regex _regex = new Regex("^[0 - 2][0 - 3]:[0-5][0-9]$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(100));
        bool IRouteConstraint.Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if(!values.TryGetValue(routeKey,out var routeValue))
            {
                return false;
            }
            var routeValueString = Convert.ToString(routeValue);

            if(routeValueString is null)
            {
                return false;
            }

            return _regex.IsMatch(routeValueString);
        }
    }
}
