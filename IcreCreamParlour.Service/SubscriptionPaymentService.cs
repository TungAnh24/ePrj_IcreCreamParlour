using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class SubscriptionPayment : ISubscriptionPaymentService
    {
        private readonly IGenericRepository<SubscriptionPayment> _repository;

        public SubscriptionPayment(IGenericRepository<SubscriptionPayment> repository)
        {
            _repository = repository;
        }

        public void DeleteSubscriptionPayment(int id)
        {
            _repository.Delete(id);
        }

        public SubscriptionPayment FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<SubscriptionPayment> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertSubscriptionPayment(SubscriptionPayment subscriptionPayment)
        {
            _repository.Insert(subscriptionPayment);
        }

        public void UpdateSubscriptionPayment(SubscriptionPayment subscriptionPayment)
        {
            _repository.Update(subscriptionPayment);
        }
        public static implicit operator SubscriptionPayment(GenericRepository<SubscriptionPayment> subscriptionPayment)
        {
            throw new NotImplementedException();
        }
    }
}
