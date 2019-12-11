using Codematers.Test.Models.Poco;
using Codematers.Test.Repository.Interfaces;
using Codematers.Test.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Codematers.Test.Services.Implementation
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly ILeaderboardRepo _repo;

        public LeaderboardService(ILeaderboardRepo repo)
        {
            _repo = repo;
        }


        public IList<Leaderboard> GetLeaderboards ()
        {
            var data = _repo.GetLeaderboards();

            if (data.Any())
            {
                
                return data.Select(l =>  new Leaderboard() { LeaderboardId = l.LeaderboardId, EventDate = l.EventDate, Location = l.Location }).ToList();
            }

            return new List<Leaderboard>();
        }

        public Leaderboard GetLeaderboard(LeaderboardFilter filter)
        {
            var data = _repo.GetLeaderboards();

            var result = new Leaderboard();

            if(data.Any())
            {
                if (filter.LeaderboardId > 0)
                {
                    result  = data
                        .Where(l => l.LeaderboardId == filter.LeaderboardId).SingleOrDefault();
                }
                if (result != null)
                {
                    if(result.Entries != null)
                    {
                        result.Entries = GetLeaderboardEntries(filter, result);
                    }
                    
                }
            }

            return result;
        }

        private List<LeaderboardEntry> GetLeaderboardEntries(LeaderboardFilter filter, Leaderboard leaderboard)
        {
            var entries =leaderboard.Entries;

            if (leaderboard.Entries.Any())
            {
                if (filter.Platform != "All")
                {
                    entries = leaderboard.Entries
                        .Where(l => l.Platform == filter.Platform).ToList();
                }

                leaderboard.TotalEntries = entries.Count;


                entries = entries.Any() ?
                    entries.Skip((filter.Page - 1) * filter.Count).Take(filter.Count).ToList() : 
                    new List<LeaderboardEntry>();
                
            }

            return entries;
        }
    }

    public class LeaderboardFilter
    {
        public int LeaderboardId { get; set; } = 0;
        public string Platform { get; set; } = "All";
        public int Count { get; set; } = 5;
        public int Page { get; set; } = 1;

    }
}
