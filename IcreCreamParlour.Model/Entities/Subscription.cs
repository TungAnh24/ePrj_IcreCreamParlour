using System;
using System.Collections.Generic;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Subscription
    {
        public Subscription()
        {
            SubscriptionPayments = new HashSet<SubscriptionPayment>();
        }

        public int SubscriptionId { get; set; }
        public string Title { get; set; }
        public int Days { get; set; }

        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
    }
}
