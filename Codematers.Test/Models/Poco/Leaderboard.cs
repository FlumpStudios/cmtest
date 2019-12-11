using System;
using System.Collections.Generic;

namespace Codematers.Test.Models.Poco
{
    public class Leaderboard
    {
        private List<LeaderboardEntry> _entries;

        public int LeaderboardId { get; set; } = 0;
        public DateTime EventDate { get; set; } = new DateTime(2000, 01, 01);
        public string Location { get; set; } = string.Empty;
        public List<LeaderboardEntry> Entries { get; set; }
        public int TotalEntries { get; set; }
        



    }
}
