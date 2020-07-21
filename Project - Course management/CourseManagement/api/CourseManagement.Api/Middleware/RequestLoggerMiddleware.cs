﻿using CourseManagement.Application.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagement.Api.Middleware
{
    public class RequestLoggerMiddleware
    {
        private readonly RequestDelegate next;

        public RequestLoggerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, IRequestLogger simpleLogger)
        {
            var date = DateTime.Now;
            simpleLogger.LogInfo($"Handling request: {context.Request.Method} {context.Request.Path}");

            await this.next.Invoke(context);

            simpleLogger.LogInfo($"Finished handling request. Milliseconds: {(DateTime.Now - date).Milliseconds}");
        }
    }
}
