using DemoDependencyInjection.CustomServices;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDependencyInjection.Middlewares
{
    public class RandomStringMiddleware
    {
        private readonly RequestDelegate _next;

        public RandomStringMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, RandomStringService randomStringSService)
        {
            await httpContext.Response.WriteAsync($"Random Value From RandomStringMiddleware :- {randomStringSService.ShowRandomString()}  \n");

            await _next(httpContext);
        }
    }
}
