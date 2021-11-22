using Caliburn.Micro;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WoodnoteWPF.ViewModels
{
    public class BirdSearchResultViewModel : Conductor<object>, IPageViewModel, 
        IHandle<IEnumerable<BirdDomain>>, IHandle<string>
    {
        public string PageTitle { get; set; } = "Bird Search Result";

        private /*readonly*/ IEventAggregator _eventAggregator;
        private BindableCollection<BirdDomain> _searchResult = new BindableCollection<BirdDomain>();

        public BindableCollection<BirdDomain> SearchResult
        {
            get
            {
                return _searchResult;
            }
            set
            {
                _searchResult = value;
                NotifyOfPropertyChange(() => SearchResult);
            }
        }


        public BirdSearchResultViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);
        }


        public async Task HandleAsync(IEnumerable<BirdDomain> message, CancellationToken cancellationToken)
        {
            await Task.Run(() => SearchResult.AddRange(message), cancellationToken);
        }

        public async Task HandleAsync(string message, CancellationToken cancellationToken)
        {
            PageTitle = message;
            NotifyOfPropertyChange(() => PageTitle);
        }
    }
}
