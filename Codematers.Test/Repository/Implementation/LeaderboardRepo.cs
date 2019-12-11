using Codematers.Test.Models.Poco;
using Codematers.Test.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Codematers.Test.Repository.Implementation
{
    public class LeaderboardRepo : ILeaderboardRepo
    {
        private readonly IList<Leaderboard> _leaderboards;

        public LeaderboardRepo()
        {
            _leaderboards = new List<Leaderboard>()
            {
                new Leaderboard
                {
                    LeaderboardId = 1,
                    EventDate = new DateTime(2019,11,2,14,0,0),
                    Location = "Hawkes Bay",
                    Entries = new List<LeaderboardEntry>()
                    {
                        new LeaderboardEntry
                        {
                            EntryId = 1,
                            EntryPosition = 1,
                            Username = "SandElf",
                            UserCountry =  "England",
                            Vehicle = "206 GTI WRC",
                            Time = new TimeSpan(0,0,3,12,134),
                            Platform =  "PS4"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 2,
                            EntryPosition = 2,
                            Username = "MoonMantis",
                            UserCountry =  "France",
                            Vehicle = "Polo GTI Rally Kit",
                            Time = new TimeSpan(0,0,3,11,534),
                            Platform =  "PC"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 3,
                            EntryPosition = 3,
                            Username = "CopperDragon",
                            UserCountry =  "England",
                            Vehicle = "Mitsubishi Lancer Evolution VI",
                            Time = new TimeSpan(0,0,3,13,278),
                            Platform =  "Xbox"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 4,
                            EntryPosition = 4,
                            Username = "Metrojan",
                            UserCountry =  "Italy",
                            Vehicle = "Mitsubishi Lancer Evolution VI",
                            Time = new TimeSpan(0,0,3,13,479),
                            Platform = "PS4"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 5,
                            EntryPosition = 5,
                            Username = "RacerMad",
                            UserCountry =  "Italy",
                            Vehicle = "SUBARU Impreza 1995",
                            Time = new TimeSpan(0,0,3,14,331),
                            Platform =  "PC"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 6,
                            EntryPosition = 6,
                            Username = "CrazyWheels3",
                            UserCountry =  "Scotland",
                            Vehicle = "Lancia Delta HF Integrale",
                            Time = new TimeSpan(0,0,3,13,570),
                            Platform =  "PS4"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 7,
                            EntryPosition = 7,
                            Username = "Ceticil",
                            UserCountry = "Spain",
                            Vehicle = "206 GTI WRC",
                            Time = new TimeSpan(0,0,3,14,432),
                            Platform =  "Xbox"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 8,
                            EntryPosition = 8,
                            Username = "Moneston",
                            UserCountry =  "England",
                            Vehicle = "206 GTI WRC",
                            Time = new TimeSpan(0,0,3,15,297),
                            Platform =  "PS4"
                        },
                        new LeaderboardEntry
                        {
                            EntryId = 9,
                            EntryPosition = 9,
                            Username = "DrivePro",
                            UserCountry = "Scotland",
                            Vehicle = "Polo GTI Rally Kit",
                            Time = new TimeSpan(0,0,3,13,908),
                            Platform =  "PC"
                        },
                    }
                },
                new Leaderboard
                {
                    LeaderboardId = 2,
                    EventDate = new DateTime(2019,11,3,14,30,0),
                    Location = "Monaro"
                }
            };
        }

        public IList<Leaderboard> GetLeaderboards()
        {
            return _leaderboards;
        }
    }
}
