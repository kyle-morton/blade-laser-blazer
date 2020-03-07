using BladeLaserBlazer.App.ViewModels.Teams;
using BladeLaserBlazer.Core.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BladeLaserBlazer.App.Pages.Team
{
    public class IndexBase : ComponentBase
    {

        protected List<TeamViewModel> teams { get; set; }
        protected int offset = 0;
        protected readonly int count = 5;
        protected bool canLoadMore = true;

        [Inject]
        private ITeamService teamService { get; set; }

        protected override async Task OnInitializedAsync()
        {

            var results = await teamService.GetAsync(count, offset);
            teams = results.Select(TeamViewModel.From).ToList();
            offset += 5;
        }

        protected async Task LoadMore()
        {
            var newTeams = await teamService.GetAsync(count, offset);
            offset += 5;
            canLoadMore = newTeams.Count == count;

            teams.AddRange(newTeams.Select(TeamViewModel.From).ToList());
        }

    }
}
