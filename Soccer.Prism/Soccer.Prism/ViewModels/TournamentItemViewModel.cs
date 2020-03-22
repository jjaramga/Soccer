using Prism.Commands;
using Prism.Navigation;
using Soccer.Common.Models;
using Soccer.Prism.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer.Prism.ViewModels
{
    public class TournamentItemViewModel:TournamentResponse
    {
        private DelegateCommand _selectTournamentCommand;
        private readonly INavigationService _navigationService;

        public DelegateCommand SelectTournamentCommand => _selectTournamentCommand ?? (_selectTournamentCommand = new DelegateCommand(SelectTournamentAsync));
        // When make "tap" execute method SelectTournament

        public TournamentItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private async void SelectTournamentAsync()
        {
            var parameters = new NavigationParameters
            {
                { "tournament", this }
            };
            await _navigationService.NavigateAsync(nameof(GroupsPage), parameters);
        }
    }
}
