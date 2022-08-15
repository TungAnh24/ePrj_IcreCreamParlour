using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly IGenericRepository<SubscriptionService> _repository;

        public SubscriptionService(IGenericRepository<SubscriptionService> repository)
        {
            _repository = repository;
        }

        public void DeleteSubscription(int id)
        {
            _repository.Delete(id);        }

        public SubscriptionService FindById(int id)
        {
            return _repository.FindById(id);        }

        public IEnumerable<SubscriptionService> GetAll()
        {
            return _repository.GetAll();        }

        public void InsertSubscription(SubscriptionService subscription)
        {
            _repository.Insert(subscription);
        }

        public void UpdateSubscription(SubscriptionService subscription)
        {
            _repository.Update(subscription);
        }
        public static implicit operator SubscriptionService(GenericRepository<SubscriptionService> subscription)
        {
            throw new NotImplementedException();
        }
    }
}
