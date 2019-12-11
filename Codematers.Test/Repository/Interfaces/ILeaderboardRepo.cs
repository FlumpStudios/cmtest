using Codematers.Test.Models.Poco;
using System.Collections.Generic;

namespace Codematers.Test.Repository.Interfaces
{
    public interface ILeaderboardRepo
    {
        IList<Leaderboard> GetLeaderboards();
    }
}
