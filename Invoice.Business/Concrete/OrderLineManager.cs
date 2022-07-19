using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice.Business.Abstract;
using Invoice.DataAccess.Abstract;
using Invoice.DataAccess.Concrete.EntityFramework;
using Invoice.Entites.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Business.Concrete
{
    public class OrderLineManager : IOrderLineService
    {
        private IOrderLineDal _orderLineDal;
        public OrderLineManager(IOrderLineDal orderLineDal)
        {
            _orderLineDal = orderLineDal;
        }
        public void Add(OrderLine orderLine)
        {
            _orderLineDal.Add(orderLine);
        }
        public void Delete(OrderLine orderLine)
        {
            _orderLineDal.Delete(orderLine);
        }
        public List<OrderLine> GetAll()
        {

            return _orderLineDal.GetList();
        }
        public List<OrderLine> GetAllByPrice(double price)
        {
            return _orderLineDal.GetList(p => p.Price == price);
        }

        public List<OrderLine> GetAllByTotal(double total)
        {
            return _orderLineDal.GetList(p => p.Total == total);
        }

        public List<OrderLine> GetAllByFicheId(int id)
        {
            string[] includes = { "Item" };
            return _orderLineDal.GetList(includes,p=>p.Id ==id);
        }

        public OrderLine GetByFicheId(int id)
        {
            return _orderLineDal.Get(p => p.Id == id);
        }
        public OrderLine GetById(int id)
        {
            return _orderLineDal.Get(p => p.Id == id);
        }
        public OrderLine GetByItemId(int id)
        {
            return _orderLineDal.Get(p => p.ItemId == id);
        }
        public void Update(OrderLine orderLine)
        {
            _orderLineDal.Update(orderLine);
        }
        public List<OrderLine> GetOrderLines()
        {
            string[] includes = {"Item" };
            return _orderLineDal.GetList(includes);
        }

    }
}
