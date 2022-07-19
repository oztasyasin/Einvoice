using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Core.DataAccess.EntityFramework;
using Invoice.DataAccess.Abstract;
using Invoice.Entites.Concrete;

namespace Invoice.DataAccess.Concrete.EntityFramework
{
    public class EfOrderLineDal : EfEntityRepositoryBase<OrderLine, EIContext>, IOrderLineDal
    {
    }
}
