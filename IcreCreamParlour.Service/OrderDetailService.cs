using IcreCreamParlour.Model.Entities;
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
        private readonly IGenericRepository<OrderDetail> _repository;

        public OrderDetailService(IGenericRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public void DeleteOrderDetail(int id)
        {
            _repository.Delete(id);
        }

        public OrderDetail FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            _repository.Insert(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _repository.Update(orderDetail);
        }
        public static implicit operator OrderDetailService(GenericRepository<OrderDetailService> oderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
