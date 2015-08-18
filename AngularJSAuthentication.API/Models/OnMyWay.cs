using System;
using System.Collections.Generic;

namespace AngularJSAuthentication.API.Models
{
    public partial class OnMyWay
    {
        public int onMyWayId { get; set; }
        public Nullable<int> bookingsId { get; set; }
        //public virtual Booking Booking { get; set; }
    }
}
