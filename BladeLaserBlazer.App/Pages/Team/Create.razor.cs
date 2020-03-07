using BladeLaserBlazer.App.ViewModels.Teams;
using BladeLaserBlazer.Core.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BladeLaserBlazer.App.Pages.Team
{
    public class CreateBase : ComponentBase 
    {

        [Inject]
        protected ITeamService teamService { get; set; }
        [Inject]
        protected NavigationManager navigationManager { get; set; }
        protected string errorMessage { get; set; }
        protected CreateViewModel vm { get; set; }

        protected override async Task OnInitializedAsync()
        {
            vm = new CreateViewModel();
        }

        protected async Task CreateTeam()
        {
            if (!vm.IsValid)
            {
                errorMessage = vm.ValidationErrors;
                return;
            }

            await teamService.CreateAsync(vm.ToModel());
            navigationManager.NavigateTo("/teams");
        }

    }
}
