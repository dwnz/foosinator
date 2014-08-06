using System;
using System.Collections.Generic;

namespace Foosinator.Models
{
    public class HomeViewModel
    {
        public List<Player> Players { get; set; }
        public Game ActiveGame { get; set; }

        public Guid PlayerId { get; set; }
        public Guid TeamPlayerId { get; set; }

        public Guid VsPlayerId { get; set; }
        public Guid VsPlayerTeamMateId { get; set; }
    }
}