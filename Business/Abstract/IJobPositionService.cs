using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobPositionService
    {
        List<JobPosition> GetAll();
        List<JobPosition> GetById(int id);
        void Add(JobPosition jobPosition);
        void Delete(JobPosition jobPosition);
        void Update(JobPosition jobPosition);
    }
}
