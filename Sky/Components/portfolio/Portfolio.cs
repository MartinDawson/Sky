using Sky.Components.channel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.portfolio
{
    public class Portfolio
    {
        [Required]
        public int Id { get; set; }
        public virtual ICollection<ChannelSubscription> ChannelSubscriptions { get; set; } = new List<ChannelSubscription>();
    }
}
