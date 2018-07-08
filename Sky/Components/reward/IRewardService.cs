using Sky.Components.portfolio;
using Sky.Components.reward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.reward
{
    public interface IRewardService
    {
        Reward GetReward(int id);
        ICollection<Reward> GetRewards(int accountNumber);
    }
}
