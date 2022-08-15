using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class SubscriptionPaymentService : ISubscriptionPaymentService
    {
        private readonly IGenericRepository<SubscriptionPaymentService> _repository;

        public SubscriptionPaymentService(IGenericRepository<SubscriptionPaymentService> repository)
        {
            _repository = repository;
        }

        public void DeleteSubscriptionPayment(int id)
        {
            _repository.Delete(id);
        }

        public SubscriptionPaymentService FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<SubscriptionPaymentService> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertSubscriptionPayment(SubscriptionPaymentService subscriptionPayment)
        {
            _repository.Insert(subscriptionPayment);
        }

        public void UpdateSubscriptionPayment(SubscriptionPaymentService subscriptionPayment)
        {
            _repository.Update(subscriptionPayment);
        }
        public static implicit operator SubscriptionPaymentService(GenericRepository<SubscriptionPaymentService> subscriptionPayment)
        {
            throw new NotImplementedException();
        }
    }
}
