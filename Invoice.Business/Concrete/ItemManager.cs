using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Business.Abstract;
using Invoice.DataAccess;
using Invoice.Entites.Concrete;

namespace Invoice.Business.Concrete
{
    public class ItemManager : IItemService
    {
        private IItemDal _itemDal;

        public ItemManager(IItemDal itemDal)
        {
            _itemDal = itemDal;
        }
        public void Add(Item item)
        {
            _itemDal.Add(item);
        }

        public void Delete(Item item)
        {
           _itemDal.Delete(item);
        }

        public List<Item> GetAll()
        {
            return _itemDal.GetList();
        }

        public Item GetByCode(string code)
        {
            return _itemDal.Get(p => p.Code == code);
        }

        public Item GetByName(string name)
        {
            return _itemDal.Get(p => p.Name == name);
        }

        public Item GetById(int id)
        {
            return _itemDal.Get(p => p.Id == id);
        }

        public void Update(Item item)
        {
            _itemDal.Update(item);
        }
    }
}
