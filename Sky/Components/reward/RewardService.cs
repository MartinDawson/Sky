using Sky.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sky.Components.portfolio;
using Sky.Components.reward;
using Sky.Components.customer;
using Microsoft.Extensions.Logging;
using Sky.Components.eligibility;
using Microsoft.EntityFrameworkCore;

namespace Sky.Components.reward
{
    public class RewardService : IRewardService
    {
        public IEligibilityService _eligibilityService { get; set; }
        private IRepository<Reward> _repository { get; set; }
        private IRepository<Customer> _customerRepository { get; set; }
        private ILogger<RewardService> _logger { get; set; }

        public RewardService(
            IEligibilityService eligibilityService,
            IRepository<Reward> repository,
            IRepository<Customer> customerRepository,
            ILoggerFactory loggerFactory)
        {
            _eligibilityService = eligibilityService;
            _customerRepository = customerRepository;
            _logger = loggerFactory.CreateLogger<RewardService>();
        }

        public ICollection<Reward> GetRewards(int accountNumber)
        {
            try
            {
                if (!_eligibilityService.IsUserEligibleForRewards(accountNumber)) return new List<Reward>();
            }
            catch (Exception ex)
            {
                if (ex is InvalidAccountNumberException)
                {
                    throw ex;
                }

                _logger.LogError(ex, ex.Message);

                throw ex;
            }

            var customer = _customerRepository.GetAll()
                .Include(x => x.Portfolio.ChannelSubscriptions)
                .ThenInclude(x => x.Reward)
                .Single(x => x.AccountNumber == accountNumber);

            return customer.Portfolio.ChannelSubscriptions.Select(x => x.Reward).ToList();
        }

        public Reward GetReward(int id)
        {
            return _repository.Get(id);
        }
    }
}
