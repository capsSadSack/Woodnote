using Caliburn.Micro;
using PolygonMapControlLibrary.ViewModels;

namespace PolygonMapControlLibrary.DataSharing
{
    public class RegionsSessionContextSingletone
    {
        #region Singletone pattern

        private static RegionsSessionContextSingletone _instance;

        public static RegionsSessionContextSingletone GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RegionsSessionContextSingletone();
            }

            return _instance;
        }

        #endregion


        public BindableCollection<RegionViewModel> SelectedRegions { get; set; } = new BindableCollection<RegionViewModel>();

        private RegionsSessionContextSingletone()
        {

        }
    }
}
