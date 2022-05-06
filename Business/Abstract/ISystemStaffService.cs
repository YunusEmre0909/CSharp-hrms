using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISystemStaffService
    {
        List<SystemStaff> GetAll();
        List<SystemStaff> GetByUserId(int id);
        void Add(SystemStaff systemStaff);
        void Update(SystemStaff systemStaff);
        void Delete(SystemStaff systemStaff);
    }
}
