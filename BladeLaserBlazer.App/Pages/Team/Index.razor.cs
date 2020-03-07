using BladeLaserBlazer.Core.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BladeLaserBlazer.App.Pages.Team
{
    public class IndexBase : ComponentBase
    {

        protected List<Core.Data.Models.Team> teams { get; set; }
        protected int Offset = 0;
        protected readonly int Count = 5;
        protected bool CanLoadMore = true;

        [Inject]
        private ITeamService TeamService { get; set; }

        protected override async Task OnInitializedAsync()
        {

            teams = await TeamService.GetAsync(Count, Offset);
            Offset += 5;
        }

        protected async Task LoadMore()
        {
            var newTeams = await TeamService.GetAsync(Count, Offset);
            Offset += 5;
            CanLoadMore = newTeams.Count == Count;

            teams.AddRange(newTeams);
        }

    }
}
