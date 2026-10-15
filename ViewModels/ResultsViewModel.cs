using ManUtdHub.Models;

namespace ManUtdHub.ViewModels;

public class ResultsViewModel
{
    public int Month { get; set; }

    public int Year { get; set; }

    public string MonthName =>
        new DateTime(Year, Month, 1).ToString("MMMM yyyy");
    public List<MatchModel> Matches { get; set; } = [];
}