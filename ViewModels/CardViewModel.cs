using System;

namespace BugsIncluded.ViewModels
{
    class CardViewModel
    {
        public CardViewModel()
        {
        }

        public string Title { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}