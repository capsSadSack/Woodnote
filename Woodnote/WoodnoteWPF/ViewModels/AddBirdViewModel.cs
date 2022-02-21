using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WoodnoteWPF.EventModels;

namespace WoodnoteWPF.ViewModels
{
    public class AddBirdViewModel : Conductor<object>, IPageViewModel,
        IHandle<OnAddBirdClickedEvent>
    {
        public string PageTitle => "Adding bird";

        private readonly IEventAggregator _eventAggregator;


        public AddBirdViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);
        }


        public async Task HandleAsync(OnAddBirdClickedEvent message, CancellationToken cancellationToken)
        {
            NotifyOfPropertyChange(() => PageTitle);
        }

        public void OnCancelClicked()
        {
            _eventAggregator.PublishOnUIThreadAsync(new OnRetunToBirdSearchEvent());
        }

        public void OnSaveBirdClicked()
        {
            _eventAggregator.PublishOnUIThreadAsync(new OnRetunToBirdSearchEvent());
        }
    }
}
