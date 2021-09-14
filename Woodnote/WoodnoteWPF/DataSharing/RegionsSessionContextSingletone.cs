using Caliburn.Micro;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.DataSharing
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


        public BindableCollection<RegionModel> SelectedRegions { get; set; } = new BindableCollection<RegionModel>();

        private RegionsSessionContextSingletone()
        {

        }
    }
}
