using System;
using System.Collections.Generic;

namespace AngularJSAuthentication.API.Models
{
    public partial class Reason
    {
        public Reason()
        {
            //this.ReceiptDelays = new List<ReceiptDelay>();
        }

        public int reasonId { get; set; }
        public string name { get; set; }
       // public virtual ICollection<ReceiptDelay> ReceiptDelays { get; set; }
    }
}
