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
        IEnumerable<SubscriptionPaymentService> GetAll();
        SubscriptionPaymentService FindById(int id);
        void InsertSubscriptionPayment(SubscriptionPaymentService subscriptionPayment);
        void UpdateSubscriptionPayment(SubscriptionPaymentService subscriptionPayment);
        void DeleteSubscriptionPayment(int id);
    }
}
