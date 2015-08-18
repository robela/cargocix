using System;
using System.Collections.Generic;

namespace AngularJSAuthentication.API.Models
{
    public partial class Message
    {
        public int messageId { get; set; }
        public Nullable<int> bookingsId { get; set; }
        public string message1 { get; set; }
       // public virtual Booking Booking { get; set; }
    }
}
