using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployerService
    {
        List<Employer> GetAll();
        List<Employer> GetAllByUserId(int id);
        void Add(Employer employer);
        void Delete(Employer employer);
        void Update(Employer employer);
    }
}
