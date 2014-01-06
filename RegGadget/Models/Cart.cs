using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public ICollection<MerchandiseItem> Items { get; set; }
        public int PersonId { get; set; } // The ID of the person making the purchase

    }
}