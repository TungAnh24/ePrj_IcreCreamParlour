using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface ISubscriptionPaymentService
    {
        IEnumerable<SubscriptionPayment> GetAll();
        SubscriptionPayment FindById(int id);
        void InsertSubscriptionPayment(SubscriptionPayment subscriptionPayment);
        void UpdateSubscriptionPayment(SubscriptionPayment subscriptionPayment);
        void DeleteSubscriptionPayment(int id);
    }
}
