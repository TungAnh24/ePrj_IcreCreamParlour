using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<OrderService> _repository;

        public OrderService(IGenericRepository<OrderService> repository)
        {
            _repository = repository;
        }

        public void DeleteOrder(int id)
        {
            _repository.Delete(id);
        }

        public OrderService FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<OrderService> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertOrder(OrderService order)
        {
            _repository.Insert(order);
        }

        public void UpdateOrder(OrderService order)
        {
            _repository.Update(order);
        }
        public static implicit operator OrderService(GenericRepository<OrderService> order)
        {
            throw new NotImplementedException();
        }
    }
}
