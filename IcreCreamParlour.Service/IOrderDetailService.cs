using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetailService> GetAll();
        OrderDetailService FindById(int id);
        void InsertOrderDetail(OrderDetailService orderDetail);
        void UpdateOrderDetail(OrderDetailService orderDetail);
        void DeleteOrderDetail(int id);
    }
}
