using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    public class Notification
    {
        public int Id { get; set; }

        public string ID;
        public string Target; // The endpoint of the notification, i.e. email address, iOS device ID, gibberin name etc.
        public string Channel; // The delivery channel, i.e. text, email, gibber etc.
        public string Message; // A textual message to deliver
        public DateTime Delivered; // The date the notification was delivered by RegGadget
        public DateTime DeliveryConfirmed; // The date the notification delivery was confirmed
    }
}