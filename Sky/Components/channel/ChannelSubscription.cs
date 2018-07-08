using Sky.Components.reward;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.channel
{
    public class ChannelSubscription
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Channel Channel { get; set; }
        public Reward Reward { get; set; }
    }
}
