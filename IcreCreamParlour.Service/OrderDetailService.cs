using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IGenericRepository<OrderDetailService> _repository;

        public OrderDetailService(IGenericRepository<OrderDetailService> repository)
        {
            _repository = repository;
        }

        public void DeleteOrderDetail(int id)
        {
            _repository.Delete(id);
        }

        public OrderDetailService FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<OrderDetailService> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertOrderDetail(OrderDetailService orderDetail)
        {
            _repository.Insert(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetailService orderDetail)
        {
            _repository.Update(orderDetail);
        }
        public static implicit operator OrderDetailService(GenericRepository<OrderDetailService> oderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
