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
using Sky.Components.reward;

namespace Sky.Components.GraphQl
{
    public class AppQuery : QueryGraphType
    {
        private readonly IRewardService _rewardService;

        public AppQuery(ILoggerFactory loggerFactory, IRewardService rewardService)
        {
            var logger = loggerFactory.CreateLogger<AppQuery>();
            _rewardService = rewardService;

            Field<ListGraphType<RewardPayload>>()
                    .Name("rewards")
                    .Argument<NonNullGraphType<IntGraphType>>("accountNumber", "The account number of the customer")
                    .Resolve(c =>
                    {
                        var accountNumber = c.GetArgument<int>("accountNumber");

                        logger.LogInformation($"Rewards called with accountNumber {accountNumber}");

                        var rewards = _rewardService.GetRewards(accountNumber).Where(x => x != null).ToList();

                        return rewards;
                    });
        }
    }
}
