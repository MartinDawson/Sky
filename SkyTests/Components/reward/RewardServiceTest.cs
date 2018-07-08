using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Sky.Components.customer;
using Sky.Components.eligibility;
using Sky.Components.reward;
using Sky.Data;
using Sky.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyTests.Components.reward
{
    [TestFixture]
    class RewardServiceTest
    {
        private RewardService _rewardService;
        private Mock<IRepository<Reward>> _mockRepository;
        private Mock<IRepository<Customer>> _mockCustomerRepository;
        private ILoggerFactory _loggerFactory;

        [SetUp]
        public void Init()
        {
            var eligibilityService = new MockEligibilityService();
            _mockRepository = new Mock<IRepository<Reward>>();
            _mockCustomerRepository = new Mock<IRepository<Customer>>();
            _loggerFactory = new LoggerFactory();

            _loggerFactory.AddDebug();

            _rewardService = new RewardService(
                eligibilityService,
                _mockRepository.Object,
                _mockCustomerRepository.Object,
                _loggerFactory);
        }

        [TestCase(1)]
        public void CustomerIneligibleForRewards_ShouldReturnEmptyRewards(int accountNumber)
        {
            var rewards = _rewardService.GetRewards(accountNumber);

            rewards.Should().BeEmpty();
        }

        [TestCase(2)]
        public void TechnicalFailure_ShouldThrowTechnicalServiceException(int accountNumber)
        {
            Action act = () => _rewardService.GetRewards(accountNumber);

            act.Should().Throw<TechnicalServiceException>();
        }

        [TestCase(3)]
        public void InvalidAccountNumber_ShouldThrowInvalidAccountNumberException(int accountNumber)
        {
            Action act = () => _rewardService.GetRewards(accountNumber);

            act.Should().Throw<InvalidAccountNumberException>();
        }

        [TestCase(4)]
        public void ValidAccountNumber_ShouldReturnRewardsList(int accountNumber)
        {
            _mockCustomerRepository.Setup(x => x.GetAll()).Returns(Seeder.Customers.AsQueryable());

            var rewards = _rewardService.GetRewards(accountNumber);

            rewards.Should().BeEquivalentTo(Seeder.ChannelSubscriptions.Select(x => x.Reward));
        }
    }
}
