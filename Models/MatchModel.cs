namespace ManUtdHub.Models;


public class MatchModel
{
  public DateTime MatchDate { get; set; }
    public string HomeTeam { get; set; } = string.Empty;
    public string AwayTeam { get; set; } = string.Empty;
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }

    public string Stadium { get; set; } = string.Empty;

    public String Competition { get; set; } = string.Empty;

    public string HomeTeamLogo { get; set; } = string.Empty;

    public string AwayTeamLogo { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

}