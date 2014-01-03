using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    public class Registration
    {
        public int Id { get; set; }

        public string EventId { get; set; }
        public string BoatId { get; set; }
        public string PersonId { get; set; }
        public DateTime PaymentId { get; set; }
        public DateTime RegTimestamp { get; set; }
        public bool Paid { get; set; }
    }
}