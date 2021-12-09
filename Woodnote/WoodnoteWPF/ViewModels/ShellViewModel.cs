using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using WoodnoteWPF.Commands;
using WoodnoteWPF.EventModels;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class ShellViewModel : Conductor<object>,
        IHandle<OnSearchResultClosedEvent>,
        IHandle<OnSearchResultRequestedEvent>
    {
        #region Fields

        private ICommand _changePageCommand;

        private List<Conductor<object>> _pageViewModels;

        private readonly IEventAggregator _eventAggregator;

        #endregion



        public ShellViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);

            // Add available pages
            PageViewModels.Add(new BirdSearchViewModel(_eventAggregator));
            PageViewModels.Add(new TimCoreyShellViewModel(_eventAggregator));
            PageViewModels.Add(new BirdSearchResultViewModel(_eventAggregator));

            // Set starting page
            ActivateItemAsync(PageViewModels[0]);
        }

        #region Properties / Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((Conductor<object>)p),
                        p => p is Conductor<object>);
                }

                return _changePageCommand;
            }
        }

        public List<Conductor<object>> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<Conductor<object>>();

                return _pageViewModels;
            }
        }

        #endregion

        #region Methods

        private void ChangeViewModel(Conductor<object> viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
            {
                PageViewModels.Add(viewModel);
            }

            ActivateItemAsync(viewModel);
        }

        public async Task HandleAsync(OnSearchResultClosedEvent message, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                ChangeViewModel(PageViewModels.Where(x => x is BirdSearchViewModel).FirstOrDefault());
            },
            cancellationToken);
        }

        public async Task HandleAsync(OnSearchResultRequestedEvent message, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                ChangeViewModel(PageViewModels.Where(x => x is BirdSearchResultViewModel).FirstOrDefault());
            },
            cancellationToken);
        }

        #endregion
    }
}
