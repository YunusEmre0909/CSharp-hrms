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
    public class SystemStaffManager : ISystemStaffService
    {
        ISystemStaffDal _systemStaffDal;
        public SystemStaffManager(ISystemStaffDal systemStaffDal)
        {
            _systemStaffDal = systemStaffDal;
        }
        public void Add(SystemStaff systemStaff)
        {
            _systemStaffDal.Add(systemStaff);
        }

        public void Delete(SystemStaff systemStaff)
        {
            _systemStaffDal.Delete(systemStaff);
        }

        public List<SystemStaff> GetAll()
        {
            return _systemStaffDal.GetAll();
        }

        public List<SystemStaff> GetByUserId(int id)
        {
            return _systemStaffDal.GetAll(s=>s.UserId==id);
        }

        public void Update(SystemStaff systemStaff)
        {
            _systemStaffDal.Update(systemStaff);
        }
    }
}
