using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface ISubscriptionService
    {
        IEnumerable<SubscriptionService> GetAll();
        SubscriptionService FindById(int id);
        void InsertSubscription(SubscriptionService subscription);
        void UpdateSubscription(SubscriptionService subscription);
        void DeleteSubscription(int id);
    }
}
