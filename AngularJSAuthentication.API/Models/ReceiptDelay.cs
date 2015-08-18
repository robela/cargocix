using System;
using System.Collections.Generic;

namespace AngularJSAuthentication.API.Models
{
    public partial class ReceiptDelay
    {
        public int receiptDelayId { get; set; }
        public Nullable<int> reasonId { get; set; }
        public Nullable<int> bookingsId { get; set; }
        public Nullable<System.DateTime> newArrivalTime { get; set; }
        public String textMsg { get; set; }
       // public virtual Booking Booking { get; set; }
       // public virtual Reason Reason { get; set; }
    }
}
