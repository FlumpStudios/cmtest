using Codematers.Test.Models.Poco;

namespace Codematers.Test.Models
{
    public class LeaderboardViewModel
    {
        public Leaderboard Leaderboard { get; set; }

        public int Page { get; set; }
        public int NextPage { get; set; }
        public int PreviousPage { get; set; }

    }
}
