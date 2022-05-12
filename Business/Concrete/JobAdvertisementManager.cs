using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobAdvertisementManager : IJobAdvertisementService
    {
        IJobAdvertisementDal _jobAdvertisementDal;

        public JobAdvertisementManager(IJobAdvertisementDal jobAdvertisementDal)
        {
            _jobAdvertisementDal = jobAdvertisementDal;
        }

        public void Add(JobAdvertisement jobAdvertisement)
        {
            _jobAdvertisementDal.Add(jobAdvertisement);
        }

        public void Delete(JobAdvertisement jobAdvertisement)
        {
            _jobAdvertisementDal.Delete(jobAdvertisement);
        }

        public List<JobAdvertisement> GetAll()
        {
            return _jobAdvertisementDal.GetAll();
        }

        public JobAdvertisement GetById(int id)
        {
            return _jobAdvertisementDal.Get(j=>j.Id==id);
        }

        public void Update(JobAdvertisement jobAdvertisement)
        {
            _jobAdvertisementDal.Update(jobAdvertisement);
        }
    }
}
