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
    public class EfSystemStaffDal : ISystemStaffDal
    {
        public void Add(SystemStaff entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SystemStaff entity)
        {
            throw new NotImplementedException();
        }

        public SystemStaff Get(Expression<Func<SystemStaff, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SystemStaff> GetAll(Expression<Func<SystemStaff, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(SystemStaff entity)
        {
            throw new NotImplementedException();
        }
    }
}
