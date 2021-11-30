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

        private int _searchResultCount = 0;
        public int SearchResultCount
        {
            get
            {
                return _searchResultCount;
            }
            set
            {
                _searchResultCount = value;
                NotifyOfPropertyChange(() => SearchResultCount);
            }
        }


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
                SearchResultCount = SearchResult.Count();
                NotifyOfPropertyChange(() => SearchResult);                
            }
        }


        public BirdSearchResultViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);
        }


        public async Task HandleAsync(OnSearchResultRequestedEvent message, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                var temp = new BindableCollection<BirdModel>();
                temp.AddRange(message.Birds);
                SearchResult = temp;
            }, cancellationToken);
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
