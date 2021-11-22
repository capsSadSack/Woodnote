using System.Collections.Generic;

namespace WoodnoteWPF.EventModels
{
    public class OnSearchResultRequestedEvent
    {
        public IEnumerable<Domain.Models.BirdDomain> Birds { get; set; }
    }
}
