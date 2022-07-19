using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Entites.Concrete;

namespace Invoice.Business.Abstract
{
    public interface IOrderLineService
    {
        List<OrderLine> GetAll();
        List<OrderLine> GetAllByPrice(double price);
        List<OrderLine> GetAllByTotal(double total);
        List<OrderLine> GetAllByFicheId(int id);
        OrderLine GetById(int id);
        OrderLine GetByItemId(int id);
        OrderLine GetByFicheId(int id);
        void Add(OrderLine orderLine);
        void Delete(OrderLine orderLine);
        void Update(OrderLine orderLine);
        List<OrderLine> GetOrderLines();
    }
}
