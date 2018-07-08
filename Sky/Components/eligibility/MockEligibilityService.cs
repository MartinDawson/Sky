using Sky.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.eligibility
{
    public class MockEligibilityService : IEligibilityService
    {
        public MockEligibilityService()
        {
        }

        /// <summary>
        /// 1 - returns false
        /// 2 - throws technical exception
        /// 3 - throws invalid account exception
        /// 4 - returns true
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public bool IsUserEligibleForRewards(int accountNumber)
        {
            if (accountNumber == 1) return false;
            if (accountNumber == 2) throw new TechnicalServiceException("Service technical failure");
            if (accountNumber == 3) throw new InvalidAccountNumberException("The supplied account number is invalid");

            return true;
        }
    }
}
