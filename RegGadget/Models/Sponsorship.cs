using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    public class Sponsorship
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public int OrganizationId { get; set; }
        public string Solicitation { get; set; } // A descriptive string describing the sponsorship opportunity
        public int Type { get; set; } // Indicates what type of sponsorship this is, i.e. title, supporting, advertising, in-kind, donation, partnership etc.
        public int Amount { get; set; } // Specifies level or funding or cost of the sponsorship
        public ICollection<string> Activations { get; set; }
        public ICollection<string> Documents { get; set; }
    }
}