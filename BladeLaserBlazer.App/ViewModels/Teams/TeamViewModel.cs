using BladeLaserBlazer.Core.Data.Models;

namespace BladeLaserBlazer.App.ViewModels.Teams
{
    public class TeamViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public static TeamViewModel From(Team team)
        {
            return new TeamViewModel
            {
                Id = team.Id,
                Location = team.Location,
                Name = team.NickName
            };
        }
    }
}
