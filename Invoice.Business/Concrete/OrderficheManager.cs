using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Invoice.Business.Abstract;
using Invoice.DataAccess.Abstract;
using Invoice.DataAccess.Concrete.EntityFramework;
using Invoice.Entites.Concrete;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Business.Concrete
{
    public class OrderficheManager : IOrderficheService
    {
        private IOrderficheDal _orderficheDal;

        public OrderficheManager(IOrderficheDal orderficheDal)
        {
            _orderficheDal = orderficheDal;
        }
        public void Add(Orderfiche orderfiche)
        {
            _orderficheDal.Add(orderfiche);
        }

        public void Delete(Orderfiche orderfiche)
        {
            _orderficheDal.Delete(orderfiche);
        }

        public List<Orderfiche> GetAll()
        {
            string[] includes = {"Client", "Lines", "Lines.Item" };
            return _orderficheDal.GetList(includes);
        }

        public Orderfiche GetByClientId(int id)
        {
           
            return _orderficheDal.Get(p => p.ClientId == id);
        }

        public Orderfiche GetByDate(DateTime date)
        {
            return _orderficheDal.Get(p => p.DateTime.Equals(date));
        }

        public Orderfiche GetByFicheNo(int id)
        {
            return _orderficheDal.Get(p => p.ficheNo == id);
        }

        public Orderfiche GetById(int id)
        {
            string[] includes = { "Client", "Lines", "Lines.Item" };
            return _orderficheDal.Get(includes);
        }

        public void Update(Orderfiche orderfiche)
        {
            _orderficheDal.Update(orderfiche);
        }

        public List<Orderfiche> GetOrderFichesWithClient()
        {
            string[] includes = { "Client", "Lines", "Lines.Item" };
            return _orderficheDal.GetList(includes);
        }

        public List<Orderfiche> GetOrderFichesWithLines()
        {
            string[] includes = { "Client", "Lines", "Lines.Item" };
            return _orderficheDal.GetList(includes);
        }
    }
}
