using Caliburn.Micro;
using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WoodnoteWPF.EventModels;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class BirdSearchResultViewModel : Conductor<object>, IPageViewModel,
        IHandle<OnSearchResultRequestedEvent>, IHandle<string>
    {
        public string PageTitle { get; set; } = "Bird Search Result";

        public string SearchResultCount { get; set; }


        private readonly IEventAggregator _eventAggregator;
        private BindableCollection<BirdModel> _searchResult = new BindableCollection<BirdModel>();

        public BindableCollection<BirdModel> SearchResult
        {
            get
            {
                return _searchResult;
            }
            set
            {
                _searchResult = value;
                SearchResultCount = _searchResult.Count().ToString();
                NotifyOfPropertyChange(() => SearchResult);
                NotifyOfPropertyChange(() => SearchResultCount);
            }
        }


        public BirdSearchResultViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);
        }


        public async Task HandleAsync(OnSearchResultRequestedEvent message, CancellationToken cancellationToken)
        {
            await Task.Run(() => SearchResult.AddRange(message.Birds), cancellationToken);
        }

        public async Task HandleAsync(string message, CancellationToken cancellationToken)
        {
            PageTitle = message;
            NotifyOfPropertyChange(() => PageTitle);
        }

        public void OnCloseClicked()
        {
            _eventAggregator.PublishOnUIThreadAsync(new OnSearchResultClosedEvent());
        }
    }
}
