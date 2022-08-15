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
        IEnumerable<Subscription> GetAll();
        Subscription FindById(int id);
        void InsertSubscription(Subscription subscription);
        void UpdateSubscription(Subscription subscription);
        void DeleteSubscription(int id);
    }
}
