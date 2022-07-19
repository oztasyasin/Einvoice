using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Core.DataAccess;
using Invoice.Entites.Concrete;

namespace Invoice.DataAccess
{
    public interface IItemDal:IEntityRepository<Item>
    {
    }
}
