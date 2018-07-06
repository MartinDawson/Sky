using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GraphQL.Relay.Types;
using DotNetEnv;
using Microsoft.AspNetCore.Hosting;

namespace Sky.Components.GraphQl
{
    public class AppQuery : QueryGraphType
    {
        public AppQuery(ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger<AppQuery>();
        }
    }
}
