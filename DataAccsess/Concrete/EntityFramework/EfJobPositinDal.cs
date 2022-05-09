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
    public class EfJobPositinDal : IJobPositionDal
    {
        public void Add(JobPosition entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(JobPosition entity)
        {
            throw new NotImplementedException();
        }

        public JobPosition Get(Expression<Func<JobPosition, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<JobPosition> GetAll(Expression<Func<JobPosition, bool>> filter = null)
        {
            using (HrmsContext context = new HrmsContext())
            {
                return filter == null ? context.Set<JobPosition>().ToList() :
                    context.Set<JobPosition>().Where(filter).ToList();
            }
        }

        public void Update(JobPosition entity)
        {
            throw new NotImplementedException();
        }
    }
}
