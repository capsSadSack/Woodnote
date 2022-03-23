using System.Collections.Generic;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.EventModels
{
    public class OnSearchResultRequestedEvent
    {
        public IEnumerable<BirdModel> Birds { get; set; }
    }
}
