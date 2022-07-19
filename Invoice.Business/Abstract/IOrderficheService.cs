using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Entites.Concrete;

namespace Invoice.Business.Abstract
{
    public interface IOrderficheService
    {
        List<Orderfiche> GetAll();
        Orderfiche GetById(int id);
        Orderfiche GetByFicheNo(int id);
        Orderfiche GetByClientId(int id);
        Orderfiche GetByDate(DateTime date);
        void Add(Orderfiche orderfiche);
        void Delete(Orderfiche orderfiche);
        void Update(Orderfiche orderfiche);
        List<Orderfiche> GetOrderFichesWithClient();

    }
}
