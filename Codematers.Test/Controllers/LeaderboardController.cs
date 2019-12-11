using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codematers.Test.Models;
using Codematers.Test.Services.Implementation;
using Codematers.Test.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codematers.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderboardController : ControllerBase
    {
        private readonly ILeaderboardService _leaderboardService;

        public LeaderboardController(ILeaderboardService leaderboardService)
        {
            _leaderboardService = leaderboardService;
        }

        [HttpGet]
        public IActionResult GetLeaderboards()
        {
            return Ok(_leaderboardService.GetLeaderboards());
        }

        [HttpPost]
        public IActionResult GetLeaderboard(LeaderboardFilter filter)
        {
            if(filter != null)
            {
                var leaderboard = _leaderboardService.GetLeaderboard(filter);

                if (leaderboard != null)
                {
                    int pages = (int)Math.Ceiling(Convert.ToDouble(leaderboard.TotalEntries) / Convert.ToDouble(filter.Count));

                    var result  =  new LeaderboardViewModel()
                    {
                        Leaderboard = leaderboard,
                        Page = filter.Page,
                        NextPage = filter.Page >= pages ? pages : filter.Page + 1,
                        PreviousPage = filter.Page > 1 ? filter.Page - 1 : 1
                    };
                    return Ok(result);
                }
            }
            return NotFound();
        }
    }
}