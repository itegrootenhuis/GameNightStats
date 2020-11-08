using System;
using System.Collections.Generic;

namespace GNS.Web
{
    public partial class GameSession
    {
        public int GameSessionId { get; set; }
        public string GameId { get; set; }
        public int GamingGroupId { get; set; }
        public int WinnerId { get; set; }
        public int? Score { get; set; }
        public DateTime? DatePlayed { get; set; }
    }
}
