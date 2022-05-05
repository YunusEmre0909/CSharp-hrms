using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntitityFramework
{
    public class EfJobSeekerDal : IJobSeekerDal
    {
        public void Add(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public JobSeeker Get(Expression<Func<JobSeeker, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<JobSeeker> GetAll(Expression<Func<JobSeeker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(JobSeeker entity)
        {
            throw new NotImplementedException();
        }
    }
}
