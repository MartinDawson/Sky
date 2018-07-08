using GraphQL.Relay.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.reward
{
    public class RewardPayload : GraphQl.NodeGraphType<Reward>
    {
        private readonly IRewardService _rewardService;

        public RewardPayload(IRewardService rewardService)
        {
            _rewardService = rewardService;

            Name = nameof(Reward);

            Id(x => x.Id);
            Field(x => x.RewardType);
        }

        public override Reward GetById(string id)
        {
            return _rewardService.GetReward(int.Parse(id));
        }
    }
}
