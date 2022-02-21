using Caliburn.Micro;
using Domain;
using Domain.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WoodnoteWPF.Converters;
using WoodnoteWPF.EventModels;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class AddBirdViewModel : Conductor<object>, IPageViewModel,
        IHandle<OnAddBirdClickedEvent>
    {
        public string PageTitle => "Adding bird";

        public BindableCollection<ColorModel> Colors
        {
            get
            {
                return _colors;
            }
            set
            {
                _colors = value;
            }
        }

        private BindableCollection<ColorModel> _colors = new BindableCollection<ColorModel>();

        private readonly BirdColorController _birdColorController;
        private readonly IEventAggregator _eventAggregator;


        public AddBirdViewModel(IEventAggregator eventAggregator, BirdColorController birdColorController)
        {
            _birdColorController = birdColorController;
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);

            Task.Factory.StartNew(() => LoadColors());
        }


        private async Task<IEnumerable<ColorModel>> LoadColors()
        {
            IEnumerable<ColorVM> colorsVM = await _birdColorController.GetBirdsColors();
            IEnumerable<ColorModel> output = colorsVM.ToColorModels();

            Colors.AddRange(output);
            return output;
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
