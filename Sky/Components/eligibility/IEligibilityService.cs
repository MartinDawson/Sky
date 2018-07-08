using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.eligibility
{
    public interface IEligibilityService
    {
        bool IsUserEligibleForRewards(int accountNumber);
    }
}
