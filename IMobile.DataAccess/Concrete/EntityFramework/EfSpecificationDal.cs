using IMobile.Core.DataAccess.EntityFramework;
using IMobile.DataAccess.Abstract;
using IMobile.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.DataAccess.Concrete.EntityFramework
{
    public class EfSpecificationDal : EfRepositoryBase<Specification, AppDbContext>, ISpecificationDal
    {
    }
}
