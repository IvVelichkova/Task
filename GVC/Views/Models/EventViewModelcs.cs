using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GVC.Views.Models
{
    public class EventViewModelcs
    {
        public int EventId { get; set; }
   
        public string EventName { get; set; }

        public string EventStartDate { get; set; }

        public decimal? OddsForFirstTeam { get; set; }

        public decimal? OddsForDraw { get; set; }

        public decimal? OddsForSecondTeam { get; set; }

    }
}
