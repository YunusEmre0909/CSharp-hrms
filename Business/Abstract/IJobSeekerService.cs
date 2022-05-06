using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobSeekerService
    {
        List<JobSeeker> GetAll();
        List<JobSeeker> GetByUserId(int id);
        void Add(JobSeeker jobSeeker);
        void Update(JobSeeker jobSeeker);
        void Delete(JobSeeker jobSeeker);


    }
}
