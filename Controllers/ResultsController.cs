using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManUtdHub.Models;
using ManUtdHub.ViewModels;

namespace ManUtdHub.Controllers;

public class ResultsController : Controller
{
    
    public IActionResult Index(int month, int year )
    {

        if (month == 0 || year == 0)
        {
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
        }
        List<MatchModel> matches = new List<MatchModel>
        {
            new MatchModel
            {
                MatchDate = new DateTime(2024, 8, 1),
                HomeTeam = "Manchester United",
                AwayTeam = "Liverpool",
                HomeScore = 2,
                AwayScore = 1,
                Stadium = "Old Trafford",
                Competition = "Premier League",
                HomeTeamLogo = "../images/Manchester_United_FC_crest.png",
                AwayTeamLogo = "../images/Liverpool-FC-logo-PNG-transparent-1024x1871.png",
                City = "Manchester"
            },
           new MatchModel
            {
                MatchDate = new DateTime(2026, 10, 1),
                HomeTeam = "Manchester United",
                AwayTeam = "Liverpool",
                HomeScore = 2,
                AwayScore = 1,
                Stadium = "Old Trafford",
                Competition = "Premier League",
                HomeTeamLogo = "../images/Manchester_United_FC_crest.png",
                AwayTeamLogo = "../images/Liverpool-FC-logo-PNG-transparent-1024x1871.png",
                City = "Manchester"
            },
             new MatchModel
            {
                MatchDate = new DateTime(2026, 9, 1),
                HomeTeam = "Manchester United",
                AwayTeam = "Leeds",
                HomeScore = 2,
                AwayScore = 1,
                Stadium = "Old Trafford",
                Competition = "Premier League",
                HomeTeamLogo = "../images/Manchester_United_FC_crest.png",
                AwayTeamLogo = "../images/leeds-united-afc-3-logo-png-transparent.png",
                City = "Manchester"
            },

        };
        matches = matches.Where(m => m.MatchDate.Month == month && m.MatchDate.Year == year).ToList();
        matches = matches.OrderByDescending(m => m.MatchDate).ToList();

        var viewModel = new ResultsViewModel
        {
            Month = month,
            Year = year,
            Matches = matches
        };

        return View(viewModel);
    }
}
