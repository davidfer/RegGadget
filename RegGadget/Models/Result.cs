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
        public string Class { get; set; }
        public string Outcome { get; set; }
    }
}