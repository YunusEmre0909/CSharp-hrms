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
    public class EmployerManager : IEmployerService
    {
        IEmployerDal _employerDal;

        public EmployerManager(IEmployerDal employerDal)
        {
            _employerDal = employerDal;
        }
        public void Add(Employer employer)
        {
            _employerDal.Add(employer);
        }

        public void Delete(Employer employer)
        {
            _employerDal.Delete(employer);
        }

        public List<Employer> GetAll()
        {
            return _employerDal.GetAll();
        }

        public List<Employer> GetAllByUserId(int id)
        {
            return _employerDal.GetAll(e=>e.UserId==id);
        }

        public void Update(Employer employer)
        {
            _employerDal.Update(employer);
        }
    }
}
