using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Core.DataAccess.EntityFramework;
using Invoice.Entites.Concrete;

namespace Invoice.DataAccess.Concrete.EntityFramework
{
    public class EfItemDal : EfEntityRepositoryBase<Item, EIContext>, IItemDal
    {
    }
}
