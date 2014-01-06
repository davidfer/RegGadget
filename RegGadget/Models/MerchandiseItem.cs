using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    /// <summary>
    /// An item for sale
    /// </summary>
    public class MerchandiseItem
    {
        [Key]
        public int Id { get; set; }
        public int OrgId { get; set; } // ID of the organization selling this item
        public int EventId { get; set; } // Optional ID of an event this item is associated with
        public string Description { get; set; }
        public float Price { get; set; }

    }
}