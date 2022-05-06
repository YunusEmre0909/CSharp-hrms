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
    public class JobSeekerManager : IJobSeekerService
    {
        IJobSeekerDal _jobSeekerDal;
        public JobSeekerManager(IJobSeekerDal jobSeekerDal)
        {
            _jobSeekerDal = jobSeekerDal;
        }
        public void Add(JobSeeker jobSeeker)
        {
            _jobSeekerDal.Add(jobSeeker);
        }

        public void Delete(JobSeeker jobSeeker)
        {
            _jobSeekerDal.Delete(jobSeeker);
        }

        public List<JobSeeker> GetAll()
        {
            return _jobSeekerDal.GetAll();
        }

        public List<JobSeeker> GetByUserId(int id)
        {
            return _jobSeekerDal.GetAll(j=>j.UserId==id);
        }

        public void Update(JobSeeker jobSeeker)
        {
            _jobSeekerDal.Update(jobSeeker);
        }
    }
}
