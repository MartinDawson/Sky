using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sky.Components.channel;
using Sky.Components.customer;
using Sky.Components.portfolio;
using Sky.Components.reward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Data
{
    public static class Seeder
    {
        private static IHostingEnvironment _env;
        public static List<ChannelSubscription> ChannelSubscriptions => new List<ChannelSubscription>
            {
                new ChannelSubscription {
                    Channel = new Channel { ChannelType = "SPORTS" },
                    Reward = new Reward { RewardType = "CHAMPIONS_LEAGUE_FINAL_TICKET" }
                },
                new ChannelSubscription {
                    Channel = new Channel { ChannelType = "KIDS" },
                },
                new ChannelSubscription {
                    Channel = new Channel { ChannelType = "MUSIC" },
                    Reward = new Reward { RewardType = "KARAOKE_PRO_MICROPHONE" }
                },
                new ChannelSubscription {
                    Channel = new Channel { ChannelType = "NEWS" },
                },
                new ChannelSubscription {
                    Channel = new Channel { ChannelType = "MOVIES" },
                    Reward = new Reward { RewardType = "PIRATES_OF_THE_CARIBBEAN_COLLECTION" }
                },
            };

        public static List<Customer> Customers = new List<Customer>
            {
                new Customer { AccountNumber = 1, Portfolio = new Portfolio { ChannelSubscriptions = ChannelSubscriptions } },
                new Customer { AccountNumber = 2, Portfolio = new Portfolio { ChannelSubscriptions = ChannelSubscriptions } },
                new Customer { AccountNumber = 3, Portfolio = new Portfolio { ChannelSubscriptions = ChannelSubscriptions } },
                new Customer { AccountNumber = 4, Portfolio = new Portfolio { ChannelSubscriptions = ChannelSubscriptions } }
            };

        public static async Task<IWebHost> SeedData(this IWebHost webHost)
        {
            using (var scope = webHost.Services.GetService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
                {
                    _env = scope.ServiceProvider.GetRequiredService<IHostingEnvironment>();

                    if (_env.IsDevelopment())
                    {
                        await context.Database.MigrateAsync();
                        await SeedCustomers(context);
                    }
                }
            }

            return webHost;
        }

        private static async Task SeedCustomers(ApplicationDbContext context)
        {
            await context.AddRangeAsync(Customers.Where(customer => !context.Customers.Any(x => x.AccountNumber == customer.AccountNumber)));
            await context.SaveChangesAsync();
        } 
    }
}
