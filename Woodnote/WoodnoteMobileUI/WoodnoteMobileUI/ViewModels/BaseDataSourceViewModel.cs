using WoodnoteMobileUI.Services;
using Xamarin.Forms;

namespace WoodnoteMobileUI.ViewModels
{
    public class BaseDataSourceViewModel<T> : BaseViewModel
    {
        public IDataStore<T> DataStore => DependencyService.Get<IDataStore<T>>();
    }
}
