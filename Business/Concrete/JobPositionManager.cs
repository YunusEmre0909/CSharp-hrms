using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobPositionManager : IJobPositionService
    {
        IJobPositionDal _jobPositionDal;
        public JobPositionManager(IJobPositionDal jobPositionDal)
        {
            _jobPositionDal = jobPositionDal;
        }
        public void Add(JobPosition jobPosition)
        {
            _jobPositionDal.Add(jobPosition);
        }

        public void Delete(JobPosition jobPosition)
        {
            _jobPositionDal.Delete(jobPosition);
        }

        public List<JobPosition> GetAll()
        {
            return _jobPositionDal.GetAll();
        }

        public List<JobPosition> GetById(int id)
        {
            return _jobPositionDal.GetAll(j=>j.Id==id);
        }

        public void Update(JobPosition jobPosition)
        {
            _jobPositionDal.Update(jobPosition);
        }
    }
}
