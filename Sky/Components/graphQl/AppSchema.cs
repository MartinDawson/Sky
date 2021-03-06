﻿using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.GraphQl
{
    public class AppSchema : Schema
    {
        public AppSchema(Func<Type, IGraphType> resolveType) : base(resolveType)
        {
            var query = (AppQuery)resolveType(typeof(AppQuery));

            Query = query;
        }
    }
}
