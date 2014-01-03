using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PublicEvent
    {
        [Key]
        public int Id { get; set; }

        public string EventName { get; set; }
        public string EventVenue { get; set; }
        public string EventHost { get; set; }
        public string EventUrl { get; set; } // Pointer to event information
        public string RegUrl { get; set; } // Pointer to event registration
        public string NORUrl { get; set; } // Pointer to Notice of Race
        public string SIUrl { get; set; } // Pointer to Sailing Instructions
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime LateRegDate { get; set; }
        public string LateRegPenaltyType { get; set; }
        public int LateRegPenaltyValue { get; set; }
    }
}