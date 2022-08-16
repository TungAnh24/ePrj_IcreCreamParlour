using IcreCreamParlour.Model.Entities;
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
        private readonly IGenericRepository<Subscription> _repository;

        public SubscriptionService(IGenericRepository<Subscription> repository)
        {
            _repository = repository;
        }

        public void DeleteSubscription(int id)
        {
            _repository.Delete(id);        }

        public Subscription FindById(int id)
        {
            return _repository.FindById(id);        }

        public IEnumerable<Subscription> GetAll()
        {
            return _repository.GetAll();        }

        public void InsertSubscription(Subscription subscription)
        {
            _repository.Insert(subscription);
        }

        public void UpdateSubscription(Subscription subscription)
        {
            _repository.Update(subscription);
        }
        public static implicit operator SubscriptionService(GenericRepository<Subscription> subscription)
        {
            throw new NotImplementedException();
        }
    }
}
