using Domain.Endpoints;
using Xamarin.Forms;

namespace WoodnoteMobileUI.ViewModels
{
    public class BaseDataStoreViewModel<T> : BaseViewModel
    {
        public IDataStore<T> DataStore => DependencyService.Get<IDataStore<T>>();
    }
}
