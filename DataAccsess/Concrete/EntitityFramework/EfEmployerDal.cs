using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntitityFramework
{
    public class EfEmployerDal : IEmployerDal
    {
        public void Add(Employer entity)
        {
            using (HrmsContext context=new HrmsContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Employer entity)
        {
            using (HrmsContext context = new HrmsContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Employer Get(Expression<Func<Employer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Employer> GetAll(Expression<Func<Employer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Employer entity)
        {
            using (HrmsContext context = new HrmsContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
