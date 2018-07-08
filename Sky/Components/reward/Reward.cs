using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sky.Components.reward
{
    public class Reward
    {
        [Required]
        public int Id { get; set; }
        public string RewardType { get; set; }
    }
}
