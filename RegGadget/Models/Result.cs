using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    public class Result
    {
        public int Id { get; set; }

        public string BoatId { get; set; }
        public string EventName { get; set; }
        public ICollection<string> EventUrls { get; set; } // Urls for sites about the event, results etc.
        public string Class { get; set; }
        public string Outcome { get; set; } // Finish position, medal or other acknowledgement of success
        public ICollection<int> ConfirmationList { get; set; } // A list of confirmations of the result
    }
}