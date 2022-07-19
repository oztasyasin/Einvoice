using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Entites.Concrete;

namespace Invoice.Business.Abstract
{
    public interface IItemService
    {
        List<Item> GetAll();
        Item GetByCode(string code);
        Item GetByName(string name);
        Item GetById(int id);
        void Add(Item item);
        void Delete(Item item);
        void Update(Item item);
    }
}
