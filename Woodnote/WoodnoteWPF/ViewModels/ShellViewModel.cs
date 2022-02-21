using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using WoodnoteWPF.Commands;
using WoodnoteWPF.EventModels;

namespace WoodnoteWPF.ViewModels
{
    public class ShellViewModel : Conductor<object>,
        IHandle<OnSearchResultClosedEvent>,
        IHandle<OnSearchResultRequestedEvent>,
        IHandle<OnAddBirdClickedEvent>,
        IHandle<OnRetunToBirdSearchEvent>
    {
        #region Fields

        private ICommand _changePageCommand;

        private List<Conductor<object>> _pageViewModels;

        private readonly IEventAggregator _eventAggregator;

        #endregion



        public ShellViewModel(IEventAggregator eventAggregator,
            SimpleContainer container)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);

            // Add available pages
            PageViewModels.Add(container.GetInstance<BirdSearchViewModel>());
            PageViewModels.Add(container.GetInstance<TimCoreyShellViewModel>());
            PageViewModels.Add(container.GetInstance<BirdSearchResultViewModel>());
            PageViewModels.Add(container.GetInstance<AddBirdViewModel>());

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

        public async Task HandleAsync(OnAddBirdClickedEvent message, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                ChangeViewModel(PageViewModels.Where(x => x is AddBirdViewModel).FirstOrDefault());
            },
            cancellationToken);
        }

        public async Task HandleAsync(OnRetunToBirdSearchEvent message, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                ChangeViewModel(PageViewModels.Where(x => x is BirdSearchViewModel).FirstOrDefault());
            },
            cancellationToken);
        }

        #endregion
    }
}
