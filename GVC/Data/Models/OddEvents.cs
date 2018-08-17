using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GVC.Data.Models
{
    public class OddEvents
    {
        [Key]
      public int EventId { get; set; }
        public string NameEvent { get; set; }
        [Required]
        public DateTime EventStartDate { get; set; }

        public decimal? OddsForFirstTeam { get; set; }

        public decimal? OddsForDraw { get; set; }

        public decimal? OddsForSecondTeam { get; set; }


    }
}
