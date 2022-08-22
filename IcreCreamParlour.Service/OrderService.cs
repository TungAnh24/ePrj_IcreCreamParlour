using IcreCreamParlour.Model.Entities;
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
        private readonly IGenericRepository<Order> _repository;

        public OrderService(IGenericRepository<Order> repository)
        {
            _repository = repository;
        }

        public void DeleteOrder(int id)
        {
            _repository.Delete(id);
        }

        public Order FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertOrder(Order order)
        {
            _repository.Insert(order);
        }

        public void UpdateOrder(Order order)
        {
            _repository.Update(order);
        }
        /*public static implicit operator OrderService(GenericRepository<OrderService> order)
        {
            throw new NotImplementedException();
        }*/
    }
}
