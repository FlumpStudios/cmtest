using Codematers.Test.Models.Poco;
using Codematers.Test.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codematers.Test.Services.Interfaces
{
    public interface ILeaderboardService
    {
        IList<Leaderboard> GetLeaderboards();
        Leaderboard GetLeaderboard(LeaderboardFilter filter);
    }
}
