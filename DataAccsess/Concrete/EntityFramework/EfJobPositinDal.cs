using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitityFramework
{
    public class EfJobPositinDal : EfEntityRepositoryBase<JobPosition,HrmsContext> ,IJobPositionDal
    {
       
    }
}
