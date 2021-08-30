using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        #region Fields

        private ICommand _changePageCommand;

        private List<Conductor<object>> _pageViewModels;

        #endregion

        public ShellViewModel()
        {
            // Add available pages
            PageViewModels.Add(new BirdSearchViewModel());
            PageViewModels.Add(new TimCoreyShellViewModel());

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

        #endregion
    }
}
