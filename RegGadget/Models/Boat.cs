using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace RegGadget.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Boat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string OwnerId { get; set; }
        public string SailNo { get; set; }
        public string AltSailNo { get; set; }
        public string BowNo { get; set; }
        public string HullNo { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string HullColor { get; set; }
        public int Year { get; set; }
        public Bitmap Image { get; set; }
        public int PHRFRating { get; set; }
        public int IRCRating { get; set; }
        public int NFSRating { get; set; } // No flying sails, typically PHRF + 13
        public int OtherRating { get; set; }
        public int Length { get; set; }
        public int Draft { get; set; }
        public int Displacement { get; set; }
        public bool OneDesign { get; set; } // True if this boat is part of a one design class}
    }
}