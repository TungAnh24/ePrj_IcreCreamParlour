using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IOrderService
    {
        IEnumerable<OrderService> GetAll();
        OrderService FindById(int id);
        void InsertOrder(OrderService order);
        void UpdateOrder(OrderService order);
        void DeleteOrder(int id);
    }
}
