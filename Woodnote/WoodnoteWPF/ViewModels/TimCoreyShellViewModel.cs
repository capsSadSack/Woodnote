using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class TimCoreyShellViewModel : Conductor<object>, IPageViewModel
    {
        public string PageTitle => "Tim Corey Page";

        private string _firstName = "Tim";
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        private readonly IEventAggregator _eventAggregator;

        public TimCoreyShellViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            People.Add(new PersonModel()
            {
                FirstName = "Tim",
                LastName = "Corey"
            });

            People.Add(new PersonModel()
            {
                FirstName = "Bill",
                LastName = "Murrey"
            });

            People.Add(new PersonModel()
            {
                FirstName = "Harry",
                LastName = "Kane"
            });
        }


        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        public BindableCollection<PersonModel> People
        {
            get
            {
                return _people;
            }
            set
            {
                _people = value;
            }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }

        public void LoadPageOne()
        {
            ActivateItemAsync(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItemAsync(new SecondChildViewModel());
        }

        public void SearchBySilhouette()
        {
            ActivateItemAsync(new BirdSearchViewModel(_eventAggregator));
        }
    }
}
