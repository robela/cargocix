using System;
using System.Collections.Generic;

namespace AngularJSAuthentication.API.Models
{
[Serializable]
    public partial class Booking
    {
        public Booking()
        {
            //this.Messages = new List<Message>();
            //this.OnMyWays = new List<OnMyWay>();
            //this.ReceiptDelays = new List<ReceiptDelay>();
        }

        public int bookingsId { get; set; }
        public Nullable<System.DateTime> arrivalTime { get; set; }
        public string location { get; set; }
        public string userId { get; set; }
        //public virtual ICollection<Message> Messages { get; set; }
        //public virtual ICollection<OnMyWay> OnMyWays { get; set; }
        //public virtual ICollection<ReceiptDelay> ReceiptDelays { get; set; }
    }
}
