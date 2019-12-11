
using System;

namespace Codematers.Test.Models.Poco
{
    public class LeaderboardEntry
    {
        public int EntryId { get; set; } = 0;
        public long EntryPosition { get; set; }
        public string Username { get; set; } = string.Empty;
        public string UserCountry { get; set; }
        public string Vehicle { get; set; } = string.Empty;
        public TimeSpan Time { get; set; } = new TimeSpan(0, 0, 0, 0, 0);
        public string Platform { get; set; } = "All";
    }
}
