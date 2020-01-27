using DemoDependencyInjection.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDependencyInjection.Extensions
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RandomStringMiddlewareExtensions
    {
        public static IApplicationBuilder UseRandomStringMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RandomStringMiddleware>();
        }
    }
}
